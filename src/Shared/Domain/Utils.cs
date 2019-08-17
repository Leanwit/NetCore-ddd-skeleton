namespace Shared.Domain
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;

    public class Utils
    {
        public static bool EndsWith(string needle, string haystack)
        {
            if (needle.Length == 0)
            {
                return true;
            }

            return haystack.Substring(-needle.Length) == needle;
        }

        public static string DateToString(DateTime date)
        {
            return date.ToString(CultureInfo.InvariantCulture);
        }

        public static DateTime StringToDate(string date)
        {
            return Convert.ToDateTime(date);
        }

        public static string JsonEncode(Object[] values)
        {
            return JsonConvert.SerializeObject(values);
        }

        public static Object[] JsonDecode(string value)
        {
            return JsonConvert.DeserializeObject<Object[]>(value);
        }
    }
}