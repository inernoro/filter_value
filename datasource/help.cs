using System;
using System.IO;
using Neo.IronLua;
using Newtonsoft.Json;

namespace filter_value.datasource
{
    public static class help
    {
        public static void save(string data, string fileName = "main.txt")
        {
            StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "//" + fileName, append: true);
            writer.WriteLine(data);
            writer.Close();
        }

        /// <summary>
        /// 用户对象转json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        } 

        /// <summary>
        /// luaTable转json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this LuaTable obj)
        {
            return LuaTable.ToJson(obj);
        } 

        /// <summary>
        /// 字符串转序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static LuaTable Deserialize(this string obj)
        {
            return LuaTable.FromJson(obj);
        }
    }
}
