using System;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Xml.Linq;

namespace Kotacs.Libraries.Utility
{
    public static class APConvert
    {
        /// <summary>
        /// Converts a specified variant into a valid Double value.  If null, returns 0.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Double.</returns>
        public static double ToNumber(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(value.ToString(), CultureInfo.InvariantCulture);
            }
        }


        /// <summary>
        /// Converts a specified variant into a valid Single/Float value.  If null, returns 0.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Single/float.</returns>		
        public static float ToFloat(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToSingle(value.ToString(), CultureInfo.InvariantCulture);
            }
        }


        /// <summary>
        /// Converts a specified Object into a valid Int32 value.  If null, returns 0
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Int</returns>
        public static int ToInt(Object value)
        {
            if (value is int)
                return (int)value;

            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else if (typeof(Enum).IsInstanceOfType(value))
            {
                return value.GetHashCode();
            }
            else
            {
                return Convert.ToInt32(value.ToString(), CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Converts a specified Object into a valid Int64 value.  If null, returns 0
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Int</returns>
        public static Int64 ToInt64(Object value)
        {
            if (value is int)
                return (int)value;

            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else if (typeof(Enum).IsInstanceOfType(value))
            {
                return value.GetHashCode();
            }
            else
            {
                return Convert.ToInt64(value.ToString(), CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Converts a specified Object into a valid string value.  Should be called when evaluating DataColumns.  If null, returns a empty string.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid string value</returns>
        public static string ToString(Object value)
        {
            if (value == null || value == System.DBNull.Value)
            {
                return "";
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>
        /// Converts a specified Object into a valid string value.  Should be called when evaluating DataColumns.  If null, returns a empty string.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid string value</returns>
        public static string ToString(XDocument value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                return value.ToString();
            }
        }



        /// <summary>
        /// Converts a given Object into a boolean value in bit format.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>An integer bit value.</returns>
        public static int ToBit(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else if (value.ToString().ToUpper(CultureInfo.InvariantCulture) == "ON")
            {
                return 1;
            }
            else if ((IsInteger(value.ToString()) ? Convert.ToBoolean(ToInt(value), CultureInfo.InvariantCulture) : Convert.ToBoolean(value, CultureInfo.InvariantCulture)) == false)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }


        /// <summary>
        /// Converts a given Object to a boolean value.  If null, then returns false
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A boolean value</returns>
        public static bool ToBoolean(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return false;
            }
            else
            {
                if (IsInteger(value.ToString()))
                {
                    return Convert.ToBoolean(ToInt(value), CultureInfo.InvariantCulture);
                }
                else
                {
                    return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
                }
            }
        }

        /// <summary>
        /// Converts an Object to a DateTime.  If null, then returns System.DateTime.MinValue
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>String representing the Object converted to DateTime</returns>
        public static System.DateTime ToDateTime(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return System.DateTime.MinValue;
            }
            else
            {
                return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
            }
        }


        /// <summary>
        /// Converts an Object to a nullable DateTime.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>String representing the Object converted to DateTime</returns>
        public static System.DateTime? ToNullableDateTime(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return null;
            }
            else
            {
                return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Converts an Object to a Date.  If null, then returns empty string
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>String representing the Object converted Date</returns>
        public static string ToDateOnly(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToDateTime(value, CultureInfo.InvariantCulture).Date.ToShortDateString();
            }
        }


        /// <summary>
        /// Converts an Object to Time.  If null, then returns System.DateTime.MinValue.ToLongTimeString()
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>String representing the Object converted to Time</returns>
        public static string ToTime(Object value)
        {
            if (value == null || value == System.DBNull.Value || String.IsNullOrEmpty(value.ToString()))
            {
                return System.DateTime.MinValue.ToLongTimeString();
            }
            else
            {
                return Convert.ToDateTime(value, CultureInfo.InvariantCulture).ToLongTimeString();
            }
        }

        /// <summary>
        /// Checks to see if a given value is a Numeric Integer
        /// </summary>
        /// <param name="Value">Value to check</param>
        /// <returns>True/False indicating whether or not the value is an integer.</returns>
        public static bool IsInteger(string value)
        {
            Int32 number;
            return Int32.TryParse(value,
              System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }

        /// <summary>
        /// Checks to see if a given value is Numeric (works for floating point numbers as well)
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>True/False indicating whether or not the value is Numeric.</returns>
        public static bool IsFloat(string value)
        {

            Double number;
            return Double.TryParse(value,
              System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

        }


        /// <summary>
        /// Determines if a given string is a valid date
        /// </summary>
        /// <param name="dateValue">String that might be a date value</param>
        /// <returns>boolean indicating if the string is a valid date</returns>
        public static bool IsDate(string dateValue)
        {
            // Make sure the string has a / in it, because all the date formats
            // we support contains /'s in them.
            // We need to do this because if we pass 1.23 in to this method, it
            // gets interpreted as a valid date
            if (dateValue.IndexOf("/", StringComparison.Ordinal) < 0)
            {
                return false;
            }
            else
            {
                try
                {
                    DateTime.Parse(dateValue, CultureInfo.InvariantCulture);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }


        /// <summary>
        /// Determines if a given string is a valid time
        /// </summary>
        /// <param name="timeeValue">String that might be a time value</param>
        /// <returns>boolean indicating if the string is a valid time</returns>
        public static bool IsTime(string timeValue)
        {
            try
            {
                DateTime.Parse(timeValue, CultureInfo.InvariantCulture);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        /// <summary>
        /// Converts an attibute id to a column alias
        /// </summary>
        /// <param name="attr"></param>
        /// <returns></returns>
        public static string IntToAttr(object attr)
        {
            return "AT" + Math.Abs(attr.GetHashCode()).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// converts from a bytes array to a Hex string
        /// </summary>
        /// <param name="bs">bytes array</param>
        /// <returns>Hex encoded string</returns>
        public static string BytesToHexString(Byte[] bs)
        {
            if (bs == null || bs.Length == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (Byte b in bs)
                sb.Append(b.ToString("x2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        /// <summary>		
        /// converts from a Hex encoded string to a bytes array
        /// </summary>
        /// <param name="hexEncoded">hexEncoded string</param>
        /// <returns>bytes array</returns>		
        public static byte[] HexStringToBytes(string hexEncoded)
        {
            if (hexEncoded == null || hexEncoded.Length == 0)
                return null;
            try
            {
                int len = hexEncoded.Length / 2;
                Byte[] bytes = new Byte[len];
                for (int i = 0; i < len; i++)
                {
                    int b = Convert.ToInt16(hexEncoded.Substring(2 * i, 2), 16);
                    bytes[i] = Convert.ToByte(b);
                }
                return bytes;
            }
            catch (Exception ex)
            {
                throw new System.FormatException("The provided string does not appear to be Hex encoded:" +
                  Environment.NewLine + hexEncoded + Environment.NewLine, ex);
            }
        }

        public static string ToCommaDelimitedString(IEnumerable list)
        {
            IEnumerator en = list.GetEnumerator();
            StringBuilder returnBuilder = new StringBuilder();

            while (en.MoveNext())
            {
                if (returnBuilder.Length != 0)
                    returnBuilder.Append(",");

                returnBuilder.Append(en.Current.ToString());
            }

            return returnBuilder.ToString();
        }

        /// <summary>
        /// Converts a specified variant into a valid Decimal value.  If null, returns 0.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Decimal.</returns>
        public static decimal ToDecimal(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(value.ToString(), CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Converts a specified variant into a valid Double value.  If null, returns 0.
        /// </summary>
        /// <param name="value">Object to Convert</param>
        /// <returns>A valid Decimal.</returns>
        public static double ToDouble(Object value)
        {
            if (value == null || value == System.DBNull.Value || value.ToString().Length == 0)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(value.ToString(), CultureInfo.InvariantCulture);
            }
        }


        /// <summary>
        /// Convert string array to Integer array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int[] ToIntegerArray(string value)
        {
            string[] splitStringArray = value.Split(',');
            int[] idList = null;
            if (!string.IsNullOrEmpty(value))
            {
                idList = new int[splitStringArray.Length];
                for (int index = 0; index < splitStringArray.Length; index++)
                {
                    idList[index] = int.Parse(splitStringArray[index], CultureInfo.InvariantCulture);
                }
            }
            return idList;
        }


    }
}
