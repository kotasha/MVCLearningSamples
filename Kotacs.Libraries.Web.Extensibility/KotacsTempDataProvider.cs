using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Kotacs.Libraries.Web.Extensibility
{
   public class KotacsTempDataProvider : ITempDataProvider
    {
        public IDictionary<string, object> LoadTempData(ControllerContext controllerContext)
        {
            var tempData = DecodeTempData(controllerContext);
            if(tempData== default(IDictionary<string,object>))
                tempData=new Dictionary<string,object>();
            return tempData;
        }
        public void SaveTempData(ControllerContext controllerContext, IDictionary<string, object> values)
        {
            var isTempDataDirty = values != default(IDictionary<string, object>) && values.Count >= 1;
            if (isTempDataDirty)
            {
                var encodedTempData = EncodeTempData(values);
                var cookie = new HttpCookie(TEMP_DATA_COOKIE_KEY, encodedTempData) { Expires = DateTime.Now.AddHours(4), HttpOnly = true };
                var response = controllerContext.HttpContext.Response;
                response.Cookies.Add(cookie);
            }
        }
        #region Helper Methods
        private IDictionary<string,object> DecodeTempData(ControllerContext controllerContext)
        {
            var tempData = default(IDictionary<string,object>);
            var request = controllerContext.HttpContext.Request;
            var tempDataCookie= request.Cookies[TEMP_DATA_COOKIE_KEY];
            if(tempDataCookie!=default(HttpCookie))
            {
                var encodedTempData= tempDataCookie.Value;
                var tempDataBytes= Convert.FromBase64String(encodedTempData);
            using(var memoryStream= new MemoryStream())
            {
                memoryStream.Write(tempDataBytes,0,tempDataBytes.Length);
                memoryStream.Flush();
                memoryStream.Position = 0;
                var binaryFormatter = new BinaryFormatter();
                tempData= binaryFormatter.Deserialize(memoryStream) as IDictionary<string,object>;
            }
            }
            return tempData;
        }
        private string EncodeTempData(IDictionary<string, object> values)
        {
            var encodedTempData= default(string);
            using(var memoryStream = new MemoryStream())
            {
                var binarySerializer = new BinaryFormatter();
                binarySerializer.Serialize(memoryStream,values);
                memoryStream.Flush();
                memoryStream.Position = 0;
                var buffer = memoryStream.GetBuffer();
                encodedTempData = Convert.ToBase64String(buffer);
            }

            return encodedTempData;
        }
#endregion
        public string TEMP_DATA_COOKIE_KEY = "Kotacs.TempData.Cookie";
    }
}
