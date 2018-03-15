using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using Kotacs.Libraries.Utility;
using System.Data;
using Kotacs.Libraries.Common.SysAdmin;

namespace Kotacs.Libraries.Common
{
  public class ConfigSettings
	{
		const string connectionStringKey = "SapphireDB";
		
		#region Public Methods
		/// <summary>
		/// Retrieve all settings from DB
		/// </summary>
		/// <returns>Setting Key/Value</returns>
		public static NameValueCollection GetSettings()
		{
			int environmentId = APConvert.ToInt(ConfigurationManager.AppSettings[GlobalConstants.EnvironmentIDAppSettingName]);
			//Get Environment settings for specific Environment Id
            return GetSettings(environmentId);
		}

		/// <summary>
		/// Retrieve Settings for Specific Environment ID
		/// </summary>
		/// <param name="environmentId">Identity of Environment</param>
		/// <returns>Setting Key/Value</returns>
		public static NameValueCollection GetSettings(int environmentId)
		{
			NameValueCollection settings = new NameValueCollection ();
            //Get SQL Reader for a specific environment
			using (IDataReader reader = GetReadSettingsReader(environmentId))
			{
				while (reader.Read())
				{
					string key = (APConvert.ToString(reader[DataConstants.SpGetEnvironmentSettingsKey])).Trim();
					string value = (APConvert.ToString(reader[DataConstants.SpGetEnvironmentSettingsValue])).Trim();
					settings.Add(key, value);
				}
			}

			return settings;
		}

		/// <summary>
		/// Retrieve Areas for specific Environment
		/// </summary>
		/// <param name="environmentId">Identity of Environment</param>
		/// <returns></returns>
		public ApplicationSettingAreas GetAreas(int environmentId)
		{
			ApplicationSettingAreas areas = new ApplicationSettingAreas();
            
            //Get Environment settings with Area names for a specific environment Id
			EnvironmentSettingInformation EnvironmentInfo=GetSettingsForUI(environmentId);
			Collection<ApplicationSetting> settings = EnvironmentInfo.Settings;
			areas.EnvironmentName = EnvironmentInfo.EnvironmentName;

            //Group the Environment related settings into relavent areas to display in UI
			areas.EnvironmentalSettingAreas = (from setting in settings
									where setting.IsEnvironmentRelated == true
									group setting by setting.Area into area
									where area.Count() != 0
									orderby area.Key
									select new ApplicationSettingsArea
									{
										Name = area.Key,
										Settings = (from areaSetting in area
																orderby areaSetting.Key
																select areaSetting).ToList(),
									}).ToList();

            //Group the Non Environment related settings into relavent areas to display in UI
            areas.NonEnvironmentalSettingAreas = (from setting in settings
								 where setting.IsEnvironmentRelated == false
									group setting by setting.Area into area
									where area.Count() != 0
									orderby area.Key
									select new ApplicationSettingsArea
									{
										Name = area.Key,
										Settings = (from areaSetting in area
																orderby areaSetting.Key
																select areaSetting).ToList(),
									}).ToList();
			return areas;
		}

		/// <summary>
		/// Save Setting values to DB
		/// </summary>
		/// <param name="settings">Settings to be saved to DB</param>
		public void SaveSettings(IEnumerable<ApplicationSetting> settings)
		{
            //Create the SQL connection to use Stored Procedures to save modified settings
			SqlConnection connection = GetConnection();
			SqlCommand command = connection.CreateCommand();
            //Use SetEnvironment settings Stored procedure to save settings to DB
			command.CommandText =DataConstants.SpSetEnvironmentSettings;
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connection;

			DataTable settingsTable = new DataTable();
			settingsTable.Columns.Add(DataConstants.EnvironmentSettingsAppSettingsID, typeof(int));
			settingsTable.Columns.Add(DataConstants.EnvironmentSettingsValue, typeof(string));

            //Add setting ID and value for each setting to be saved
			foreach (var setting in settings)
			{
				DataRow row = settingsTable.NewRow();
				row[DataConstants.EnvironmentSettingsAppSettingsID] = setting.Id;
				row[DataConstants.EnvironmentSettingsValue] = setting.Value;
				settingsTable.Rows.Add(row);
			}
            //Add settings to be saved as parameters of Stored procedure
			command.Parameters.AddWithValue(DataConstants.ParamAppSettings, settingsTable);

			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			finally
			{
				connection.Close();
			}
		}
		#endregion

		#region Private Methods

		/// <summary>
		/// Get settings for Areas using Stored Procedure
		/// </summary>
		/// <param name="environmentId">Identity of Environment</param>
		/// <returns>Environment Setting Information</returns>
		private static EnvironmentSettingInformation GetSettingsForUI(int environmentId)
		{
			EnvironmentSettingInformation settingInfo = new EnvironmentSettingInformation();
			Collection<ApplicationSetting> settings = new Collection<ApplicationSetting>();

            //Get SQL Reader for a specific environment
			using (IDataReader reader = GetReadSettingsReader(environmentId))
			{
				while (reader.Read())  //Read data set of settings information
				{
					ApplicationSetting setting = new ApplicationSetting();
					setting.Id = APConvert.ToInt(reader[DataConstants.SpGetEnvironmentSettingsAppSettingID]);
					setting.Key = (APConvert.ToString(reader[DataConstants.SpGetEnvironmentSettingsKey])).Trim();
					setting.Value = (APConvert.ToString(reader[DataConstants.SpGetEnvironmentSettingsValue])).Trim();
					setting.Area = (APConvert.ToString(reader[DataConstants.SpGetEnvironmentSettingsAreaName])).Trim();  //Area name of the setting
					setting.IsEnvironmentRelated = APConvert.ToBoolean(reader[DataConstants.SpGetEnvironmentSettingsIsEnvironmentRelated]);  //Whether setting is Environment related or not
                    setting.IsReadOnly = APConvert.ToBoolean(reader[DataConstants.SpGetEnvironmentSettingsIsReadOnly]); //Whether setting is Read only or editable
                    settings.Add(setting);
				}
				reader.NextResult();
				if (reader.Read())  //Get the environment name for the environment id from the databse SP
				{
					settingInfo.EnvironmentName = reader[DataConstants.SpGetEnvironmentSettingsEnvironmentName].ToString();
				}
				else
				{
					settingInfo.EnvironmentName = string.Empty;
				}
			}
			settingInfo.Settings = settings;
			return settingInfo;
		}

		/// <summary>
		/// Open SQL connection and Execute to get Settings
		/// for a specific environment using SP
		/// </summary>
		/// <param name="environmentId">Identity of Environment</param>
		/// <returns>IDataReader</returns>
		private static IDataReader GetReadSettingsReader(int environmentId)
		{
			SqlConnection connection = GetConnection();
			SqlCommand command = connection.CreateCommand();
			command.CommandText = DataConstants.SpGetEnvironmentSettings; //Use a Stored procedure to get environment settings
			command.CommandType = CommandType.StoredProcedure;
			command.Connection = connection;

			command.Parameters.AddWithValue(DataConstants.ParamEnvironmentID, environmentId);

			connection.Open();
			return command.ExecuteReader(CommandBehavior.CloseConnection);
		}

		/// <summary>
		/// Creates SQL connection
		/// </summary>
		/// <returns>SqlConnection</returns>
		private static SqlConnection GetConnection()
		{
			string connectionString = ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString; //Use web config to get connection string
			SqlConnection connection = new SqlConnection(connectionString);
			return connection;
		}

		#endregion
	}


}


