using System.Collections.Generic;
using Neo.IronLua;
using Newtonsoft.Json;

namespace filter_value.com
{
    public static class JSON
    {
        public static string SerializeObject(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static string SerializeObject(this object obj, Formatting formatting)
        {
            return JsonConvert.SerializeObject(obj, formatting);
        }

        public static T DeserializeObject<T>(this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }

        public static T DeserializeObject<T>(this object obj)
        {
            return JsonConvert.DeserializeObject<T>(obj.ToString() ?? string.Empty);
        }

        public static dynamic DeserializeObject(this string obj)
        {
           return JsonConvert.DeserializeObject<Dictionary<string, string>>(obj);
             
        }

    }
}