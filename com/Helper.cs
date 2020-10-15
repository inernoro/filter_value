using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace filter_value.com
{
    public static partial class Helper
    {
        /// <summary>
        /// 不能为0
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="message"></param>
        public static void IsZero(IConvertible obj, string message)
        {
            if (obj.ToInt32() == 0)
            {
                throw new Exception(message);
            }
        }

        /// <summary>
        /// 不能为空
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="message"></param>
        public static void AssertNotNull(this object obj, string message)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        /// <summary>
        /// 不能为默认值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="message"></param>
        public static void AssertNotDefault<T>(this T obj, string message)
        {
            if (obj.Equals(default(T)))
            {
                throw new Exception(message);
            }
        }

        public static bool IsNotNullOrMinTime(this DateTime? time)
        {
            return time != null && time != DateTime.MinValue;
        }

        public static bool IsNullOrMinTime(this DateTime? time)
        {
            return !IsNotNullOrMinTime(time);
        }

        public static string As(this string str, string alias)
        {
            return str + " as " + alias;
        }

        public static byte[] ToBytes(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static byte[] GetBytes(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static byte[] GetBytes<T>(this T str)
        {
            return Encoding.UTF8.GetBytes(str.SerializeObject());
        }

        //public static T Bytes2Object<T>(this byte[] str)
        //{
        //    return Encoding.UTF8.GetString(str).DeserializeObject<T>();
        //}

        public static long GetNow()
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var diff = DateTime.Now - origin;
            return (long)diff.TotalMilliseconds;
        }

        public static DateTime GetNowDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// 普通对象转redisEntity,需注意,对象要是基础类型,string,double,int这种
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static HashEntry[] ToRedisHashEntity<T>(this T t)
        {
            var type = typeof(T);
            var pro = type.GetProperties();
            var entries = new HashEntry[pro.Length + 1];

            for (int index = 0; index < pro.Length; index++)
            {
                var property = pro[index];
                var value = type.GetProperty(property.Name)?.GetValue(t);
                if (value != null)
                {
                    entries[index] = new HashEntry(property.Name, (RedisValue)value);
                }
            }

            return entries;
        }

        /// <summary>
        /// 不安全的检索方式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static object[] UnsafeObjectToArray<T>(this T t)
        {
            var type = t.GetType();
            var eachObj = type.GetProperties();
            var objRet = new object[eachObj.Length + 1];
            for (var index = 0; index < eachObj.Length; index++)
            {
                var propertyInfo = eachObj[index];
                objRet[index] = type.GetProperty(propertyInfo.Name)?.GetValue(t);
            }

            return objRet;
        }

        /// <summary>
        /// 变态的设计
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cols">大小写需一致</param>
        /// <returns></returns>
        public static IEnumerable<object> ObjectToArray<T>(this T t, params string[] cols)
        {
            var type = t.GetType();
            var objRet = new object[cols.Length];
            for (var colsIndex = 0; colsIndex < cols.Length; colsIndex++)
            {
                var colName = cols[colsIndex];
                objRet[colsIndex] = type.GetProperty(colName)?.GetValue(t);
            }

            return objRet;
        }

        /// <summary>
        /// 变态的设计
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tArray"></param>
        /// <param name="cols">大小写需一致</param>
        /// <returns></returns>
        public static List<IEnumerable<object>> ArrayObjectToArray<T>(this IEnumerable<T> tArray, params string[] cols)
        {
            var type = typeof(T);
            var list = new List<IEnumerable<object>>();
            foreach (var t in tArray)
            {
                var objRet = new object[cols.Length];
                for (var colsIndex = 0; colsIndex < cols.Length; colsIndex++)
                {
                    var colName = cols[colsIndex];
                    objRet[colsIndex] = type.GetProperty(colName)?.GetValue(t);
                }

                list.Add(objRet);
            }

            return list;
        }

        public static bool IsNullOrWhiteSpace2(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNotNullOrWhiteSpace(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        public static bool IsNotNullOrZero(this int? str)
        {
            return str != null && str != 0;
        }

        public static bool IsNotNullOrZero(this byte? str)
        {
            return str != null && str != 0;
        }

        public static bool IsNotNullOrZero(this long? str)
        {
            return str != null && str != 0;
        }

        public static bool IsNullOrZero(this int? str)
        {
            return !IsNotNullOrZero(str);
        }

        public static bool IsNullOrZero(this byte? str)
        {
            return !IsNotNullOrZero(str);
        }

        public static bool IsNullOrZero(this long? str)
        {
            return !IsNotNullOrZero(str);
        }

        public static string ToExceptionString(this object obj)
        {
            return obj.ToString();
        }

        public static string ToExceptionString(this IDictionary dictionary)
        {
            var str = "";
            foreach (DictionaryEntry dictionaryEntry in dictionary)
            {
                str += dictionaryEntry.Key + " = " + dictionaryEntry.Value.ToExceptionString().NewLine();
            }

            return str;
        }

        public static string ToExceptionString(this Exception exception)
        {
            if (exception == null || exception.Data.Equals(null))
            {
                return "";
            }

            var str = exception.Data.ToExceptionString().NewLine() +
                      "HResult=" + exception.HResult.ToString().NewLine() +
                      "HelpLink=" + exception.HelpLink.NewLine() +
                      "InnerException=" + exception.InnerException.ToExceptionString().NewLine() +
                      "Message=" + exception.Message.NewLine() +
                      "Source=" + exception.Source.NewLine() +
                      "StackTrace=" + exception.StackTrace.NewLine() +
                      "TargetSite=" + exception.TargetSite.SerializeObject().NewLine();
            return str;
        }

        /// <summary>
        /// 是否包含
        /// </summary>
        /// <param name="str"></param>
        /// <param name="isStr"></param>
        /// <returns></returns>
        public static bool IsInclude(this string str, string isStr)
        {
            if (str.IsNullOrWhiteSpace2() || isStr.IsNullOrWhiteSpace2())
            {
                return false;
            }
            return str.IndexOf(isStr, StringComparison.OrdinalIgnoreCase) != -1;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this string str, string join, string sp = "")
        {
            return str + sp + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this int str, string join, string sp = "")
        {
            return str.ToString() + sp + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this string str, int join, string sp = "")
        {
            return str + sp + join.ToString();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this int str, string join, Punctuation sp)
        {
            return str.ToString() + GetPunctuation(sp) + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this string str, int join, Punctuation sp)
        {
            return str + GetPunctuation(sp) + join.ToString();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge<TType, TYpe2>(this TType str, TYpe2 join, Punctuation sp)
        {
            return str.ToString() + GetPunctuation(sp) + join.ToString();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this string str, string join, Punctuation sp)
        {
            return str + GetPunctuation(sp) + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeColon(this string str, string join)
        {
            return str + GetPunctuation(Punctuation.Colon) + join;
        }

        /// <summary>
        /// 拼接放大
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeColonToUpper(this string str, string join)
        {
            return (str + GetPunctuation(Punctuation.Colon) + join).ToUpper();
        }

        /// <summary>
        /// 拼接放大
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeColonToUpper<T>(this string str, T join)
        {
            return (str + GetPunctuation(Punctuation.Colon) + join.ToString()).ToUpper();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeColon(this string str, int join)
        {
            return str + GetPunctuation(Punctuation.Colon) + join.ToString();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeColon<T>(this string str, T join)
        {
            return str + GetPunctuation(Punctuation.Colon) + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeVertical(this string str, string join)
        {
            return str + GetPunctuation(Punctuation.Vertical) + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeVertical(this string str, int join)
        {
            return str + GetPunctuation(Punctuation.Vertical) + join.ToString();
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        public static string MergeVertical<T>(this string str, T join)
        {
            return str + GetPunctuation(Punctuation.Vertical) + join;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sp">分隔符</param>
        /// <returns></returns>
        public static string Merge(this string str, Punctuation sp)
        {
            return str + GetPunctuation(sp);
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NewLine(this string str)
        {
            return str + Environment.NewLine;
        }

        /// <summary>
        /// 自动回车(带行号)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startLine">起始行</param>
        /// <returns></returns>
        public static string NewLine(this IEnumerable<object> str, int startLine)
        {
            if (str == null || !str.Any())
            {
                return "";
            }

            var index = startLine;
            return string.Join(Environment.NewLine, str.Select(w => (index++) + "." + w).ToList());
        }

        /// <summary>
        /// 自动回车
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NewLine<T>(this IEnumerable<T> str)
        {
            if (str == null || !str.Any())
            {
                return "";
            }

            return string.Join(Environment.NewLine, str.Select(w => w).ToList());
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string NewLine(this string str, string str2)
        {
            return str + Environment.NewLine + str2;
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static string Merge(this IEnumerable<string> str, string sp = "")
        {
            return string.Join(sp, str);
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static string Merge<T>(this IEnumerable<T> str, string sp = "")
        {
            return string.Join(sp, str);
        }

        /// <summary>
        /// 拼接
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static string Merge(this IEnumerable<string> str, Punctuation sp)
        {
            return string.Join(GetPunctuation(sp), str);
        }

        public static string GetPunctuation(Punctuation sp)
        {
            return sp switch
            {
                Punctuation.NewLine => Environment.NewLine,
                Punctuation.Semicolon => ";",
                Punctuation.Comma => ",",
                Punctuation.Colon => ":",
                Punctuation.Space => " ",
                Punctuation.Tab => "\t",
                Punctuation.Dot => ".",
                Punctuation.Underline => "_",
                Punctuation.HorizontalBar => "-",
                Punctuation.Vertical => "|",
                _ => throw new ArgumentOutOfRangeException(nameof(sp), sp, null),
            };
        }

        /// <summary>
        /// 获取正随机数(start+end 不等于0)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int GetRandom(int start, int end)
        {
            if (start + end == 0)
            {
                return 0;
            }

            StringBuilder sb = new StringBuilder();
            for (var index = 0; index < 100; index++)
            {
                sb.Append(Guid);
            }

            var str = sb.ToString();
            var array = str.ToCharArray().Select(x => (int)x).ToList();
            var w = array.Where(t => t != 0).Aggregate(1, (current, t) => current + t);
            var rsVar = w % (end - start + 1) + start;
            return rsVar;
        }

        public static int ToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        public static string Guid => System.Guid.NewGuid().ToString("N").Substring(0, 31);

        public static string Pretty(this object str)
        {
            return str.SerializeObject(Formatting.Indented);
        }

        public static string Pretty(this string str)
        {
            return JsonConvert.DeserializeObject(str).SerializeObject(Formatting.Indented);
        }

        public enum Punctuation
        {
            /// <summary>
            /// <summary>获取为此环境定义的换行字符串。</summary>
            /// <returns>对于非 Unix 平台为包含“\r\n”的字符串，对于 Unix 平台则为包含“\n”的字符串。</returns>
            /// </summary>
            NewLine,

            /// <summary>
            /// 分号 (;)
            /// </summary>
            Semicolon,

            /// <summary>
            /// 逗号 (,)
            /// </summary>
            Comma,

            /// <summary>
            /// 冒号 (:)
            /// </summary>
            Colon,

            /// <summary>
            /// 空格 ()
            /// </summary>
            Space,

            /// <summary>
            /// 制表符 (   )
            /// </summary>
            Tab,

            /// <summary>
            /// 点 (.)
            /// </summary>
            Dot,

            /// <summary>
            /// 下划线 (_)
            /// </summary>
            Underline,

            /// <summary>
            /// 一竖 (|)
            /// </summary>
            Vertical,

            /// <summary>
            /// 横杠 (-)
            /// </summary>
            HorizontalBar,
        }

        public static bool NotExistsOrDefault<T>(this T t)
        {
            if (t.Equals(default(T)))
            {
                return false;
            }

            return true;
        }

        public static T NotExistsOrDefault<T>(this T t, Exception action)
        {
            if (t.Equals(default(T)))
            {
                throw action;
            }

            return t;
        }

        /// <summary>
        /// 求精度
        /// </summary>
        /// <param name="de"></param>
        /// <param name="dec "></param>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static decimal ToRound(this decimal de, int dec)
        {
            var f = Math.Pow(10, dec);
            var g = Math.Floor(de.ToDouble() * f);
            var r = g / Math.Pow(10, dec);
            return r.ToDecimal();
        }

        /// <summary>
        /// 求精度
        /// </summary>
        /// <param name="de"></param>
        /// <param name="dec "></param>
        /// <returns></returns>
        public static double ToRound(this double de, int dec)
        {
            var f = Math.Pow(10, dec);
            var g = Math.Floor(de * f);
            var r = g / Math.Pow(10, dec);
            return r;
        }

        public static string ClearSpace(this string str)
        {
            return str.Replace(" ", "");
        }

        public static string ClearFirstAndLastSpace(this string str)
        {
            return str.TrimStart(' ').TrimEnd(' ');
        }

        public static string Serialize(params KeyValuePair<string, object>[] merge)
        {
            return merge.SerializeObject();
        }
    }
}