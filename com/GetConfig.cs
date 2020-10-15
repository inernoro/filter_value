using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace filter_value.com
{
    /// <summary>
    /// 配置管理
    /// </summary>
    public static class GetConfig
    {

        private static ConcurrentDictionary<string, string> _preConfig = new ConcurrentDictionary<string, string>();

        private static ConcurrentDictionary<string, string> _config = new ConcurrentDictionary<string, string>();

        //方法函数(new)
        private static ConcurrentDictionary<string, Func<string, string>> _func = new ConcurrentDictionary<string, Func<string, string>>();

        public static ConcurrentDictionary<string, string> GetSettings()
        {
            return _config;
        }

        /// <summary>
        /// 重置实体
        /// </summary>
        /// <returns></returns>
        public static void PerformBadly()
        {
            LoadNewConfig(true);
            _config = new ConcurrentDictionary<string, string>();
        }


        /// <summary>
        /// 添加一个方法变量
        /// </summary>
        /// <param name="key"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        [Obsolete]
        public static void TryAddFunc(string key, Func<string, string> func)
        {
            if (func == null)
            {
                throw new NullReferenceException("方法函数不能为空");
            }
            _func.TryAdd(key, func);
        }

        /// <summary>
        /// 核心获取方法
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string Get(string key, string defaultValue = null)
        {
            if (_config.ContainsKey(key))
            {
                if (_config.TryGetValue(key, out var value))
                {
                    if (value != null)
                    {
                        var output = CheckFunc(key, value);
                        return output;
                    }
                }
                return defaultValue;
            }
            else
            {
                if (_preConfig.TryGetValue(key, out var configFileValue))
                {
                    configFileValue = Replace(configFileValue);
                }
                else
                {
                    if (defaultValue != null)
                    {
                        configFileValue = Replace(defaultValue);
                    }
                    else
                    {
                        throw new Exception($"{key},此键未设定默认值,并且也无配置值,可能会在运行中产生错误,请注意!");
                        //var output = CheckFunc(key, null);
                        return null;
                    }
                }
                configFileValue = CheckFunc(key, configFileValue);
                _config.TryAdd(key, configFileValue);
                return configFileValue;
            }
        }

        private static string CheckFunc(string key, string value)
        {
            return value;
            if (key.IndexOf("$$", StringComparison.Ordinal) != -1)
            {
                var m = key.Substring(key.LastIndexOf("$", StringComparison.Ordinal) + 1);
                if (_func.TryGetValue(m, out var func))
                {
                    value = func(value);
                }
                else
                {
                    throw new Exception($"未找到该{m}配置函数");
                }
            }
            return value;

        }

        private static string Replace(string value)
        {
            if (string.IsNullOrWhiteSpace(value)
                || value.IndexOf("{{", StringComparison.Ordinal) == -1
                || value.LastIndexOf("}}", StringComparison.Ordinal) == -1)
            {
                return value;
            }
            ICollection<string> matches =
                Regex.Matches(value.Replace(Environment.NewLine, ""), @"\{\{([^}]*)\}\}")
                    .Cast<Match>()
                    .Select(x => x.Groups[1].Value)
                    .ToList();

            foreach (var match in matches)
            {
                switch (match)
                {
                    default:
                        if (_preConfig.ContainsKey(match))
                        {
                            if (value == "{{" + match + "}}")
                            {
                                _preConfig.TryGetValue(match, out value);
                                return value;
                                // throw new Exception($"抱歉,不允许变量引用本身!");
                            }
                            value = value.Replace("{{" + match + "}}", GetConfig.GetString(match));
                        }
                        else
                        {
                            throw new Exception($"抱歉,没有key=>{match}的环境变量或配置项!");
                        }
                        break;
                }
            }
            return value;
        }

        /// <summary>
        /// 覆盖配置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Set(string key, string value)
        {
            value = Replace(value);
            _config.AddOrUpdate(key, value, (x, y) => value);
            return value;
        }

        /// <summary>
        /// 删除配置文件,使其重新从配置文件缓冲区获取
        /// ps:使用场景,当使用set破坏了配置值,使其重置为最初从配置文件读取的值
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            _config.TryRemove(key, out _);
        }

        public static string GetString(string key)
        {
            return Get(key);
        }

        public static string[] GetArray(string key, string defaultValue = "")
        {
            return Get(key, defaultValue).Split(',');
        }

        public static int[] GetIntArray(string key)
        {
            return Get(key).Split(',').Select(x => Convert.ToInt32(x)).ToArray();
        }

        public static int GetInt(string key)
        {
            if (int.TryParse(Get(key), out var output))
            {
                return output;
            }
            return 0;
        }

        public static int GetInt(string key, int defaultValue)
        {
            string v;
            if ((v = Get(key, defaultValue.ToString())) == null)
            {
                return defaultValue;
            }
            if (int.TryParse(v, out var output))
            {
                return output;
            }
            return 0;
        }

        public static bool GetBoolean(string key, bool defaultValue)
        {
            return Convert.ToBoolean(Get(key, defaultValue.ToString()));
        }

        /// <summary>
        /// 当配置文件为bool时,为true才会执行(未配置默认为false)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <param name="action"></param>
        public static void ExecuteBoolean(string key, bool defaultValue, Action action)
        {
            var value = GetBoolean(key, defaultValue);
            if (value)
            {
                action();
            }
        }

        /// <summary>
        /// 当配置文件为string时(自动配置环境变量)注意判断
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        public static void ExecuteString(string key, Action<string> action)
        {
            var value = Get(key);
            action(value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        public static void ExecuteArray(string key, Action<string[]> action)
        {
            var value = Get(key);
            var sp = value.Split(',');
            action(sp);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        public static void ExecuteArrayNode(string key, Action<string> action)
        {
            var value = Get(key);
            var sp = value.Split(',');
            foreach (var node in sp)
            {
                action(node);
            }
        }

        /// <summary>
        /// 重新加载所有配置文件
        /// </summary>
        public static void ReLoad(Invisible invisible)
        {
            PerformBadly();
        }

        public enum Invisible
        {
            /// <summary>
            /// 影响最小(仅更改实例标示)
            /// </summary>
            Minimize,

            /// <summary>
            /// 全部(完全类型新主机)
            /// </summary>
            All,

            /// <summary>
            /// 不操作(包括实例标示)
            /// </summary>
            None,
        }

        private static void ExecuteEach<T>(string key, IEnumerable<T> each, Action<T> action)
        {
            var enumerable = each as T[] ?? each.ToArray();
            if (!enumerable.Any())
            {
                return;
            }
            var get = Get(key).ToLower();

            if (get == "sync")
            {
                foreach (var x in enumerable)
                {
                    NewMethod(key, action, x);
                }
            }
            else
            {
                Parallel.ForEach(enumerable, x =>
                {
                    NewMethod(key, action, x);
                });
            }
        }

        private static void NewMethod<T>(string key, Action<T> action, T node)
        {
            try
            {
                action(node);
            }
            catch (Exception e)
            {
                var ignore = GetBoolean(key + ".Ignore.Errors", false);
                //TODO错误保存到相应的错误信息类
                if (!ignore)
                {
                    throw new Exception(e.ToString());
                }
            }
        }

        /// <summary>
        /// 执行外部任务时,使用公共配置
        /// </summary>
        /// <param name="action"></param>
        private static T ExecuteExternalConnection<T>(Func<T> action)
        {
            return ExecuteExternalConnectionPrivate("ExecuteExternalTask.External.Ignore.Errors", action);
        }

        /// <summary>
        /// 执行外部任务时使用私有配置
        /// </summary>
        private static T ExecuteExternalConnection<T>(string key, Func<T> action)
        {
            return ExecuteExternalConnectionPrivate(key, action);
        }

        /// <summary>
        /// 执行外部请求没有返回值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="action"></param>
        private static void ExecuteExternalConnectionAction(string key, Action action)
        {
            var data = ExecuteExternalConnectionPrivate(key, () => action);
        }

        /// <summary>
        /// 公共操作类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        private static T ExecuteExternalConnectionPrivate<T>(string key, Func<T> action)
        {
            var currentErrorCount = 0;
            resend:
            try
            {
                return action();
            }
            catch (Exception e)
            {
                var ignore = GetBoolean(key, false);
                //TODO错误保存到相应的错误信息类
                if (!ignore)
                {
                    throw new Exception(e.ToString());
                }
                currentErrorCount++;
                //重发配置
                var resend = GetBoolean(key + ".Resend", false);
                if (resend)
                {
                    //重发次数
                    var resendCount = GetInt(key + ".Resend.Count");
                    //重发次数少于配置项
                    if (currentErrorCount < resendCount)
                    {
                        //重发延迟时间
                        var resendDelay = GetInt(key + ".Resend.Delay");
                        Thread.Sleep(resendDelay * 1000);
                        goto resend;
                    }
                }
                return default(T);
            }
        }

        public static void LoadNewConfig(bool print = false)
        {
            var dictionary = new Dictionary<string, string>();
            //using (var reader = new StreamReader(Environment.CurrentDirectory + "/property.ini"))
            using (var reader = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "/property.ini"))
            {
                string input;
                var rei = 0;
                while ((input = reader.ReadLine()) != null)
                {
                    rei++;
                    try
                    {
                        var cc = input.ClearFirstAndLastSpace();
                        if (cc.IndexOf("#", StringComparison.Ordinal) == 0)
                        {
                            continue;
                        }
                        if (cc.IndexOf("[", StringComparison.Ordinal) == 0)
                        {
                            continue;
                        }
                        if (cc.IsNotNullOrWhiteSpace())
                        {
                            var index = cc.IndexOf('=');
                            var key = cc.Substring(0, index).ClearFirstAndLastSpace().TrimStart('\"').TrimEnd('\"').ClearFirstAndLastSpace();
                            var value = cc.Substring(index + 1).ClearFirstAndLastSpace().TrimStart('\"').TrimEnd('\"').ClearFirstAndLastSpace();
                            if (!dictionary.ContainsKey(key))
                            {
                                dictionary.Add(key, value);
                            }
                            else
                            {
                                ConsoleLog.WriteLine(" CONFIG_DUPLICATION ", "No.", rei.ToString(), "  ", "KEY=>[", key, "]");
                                Console.ReadKey();
                                return;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ConsoleLog.WriteLine(" CONFIG_ERROR ", "No.", rei.ToString(), "  ", "=> ", e.ToString());
                    }
                }
            }

            if (print)
            {
                ConfigDiff(_preConfig, dictionary);
            }
            //执行修改
            _preConfig = new ConcurrentDictionary<string, string>(dictionary);
        }

        public class Modify
        {
            public string Key { get; set; }

            public string OldValue { get; set; }

            public string NewValue { get; set; }
        }

        private static void ConfigDiff(IDictionary<string, string> oldConf, IDictionary<string, string> newConfig)
        {
            var print = new Dictionary<string, string>();

            //列出新增部分
            foreach (var node in newConfig)
            {
                if (!oldConf.ContainsKey(node.Key))
                {
                    print.Add(node.Key, node.Value);
                }
            }

            if (print.Any())
            {
                ConsoleLog.WriteLine("CONFIG_ADD");
                ConsoleLog.TablePrint(print);
                print = new Dictionary<string, string>();
            }

            //列出删除部分
            foreach (var node in oldConf)
            {
                if (!newConfig.ContainsKey(node.Key))
                {
                    print.Add(node.Key, node.Value);
                }
            }

            if (print.Any())
            {
                ConsoleLog.WriteLine("CONFIG_DELETE");
                ConsoleLog.TablePrint(print);
            }
            var modifys = new List<Modify>();
            //列出修改部分
            foreach (var node in oldConf)
            {
                if (newConfig.TryGetValue(node.Key, out var value))
                {
                    if (node.Value.ClearFirstAndLastSpace() != value.ClearFirstAndLastSpace())
                    {
                        modifys.Add(new Modify()
                        {
                            Key = node.Key,
                            OldValue = node.Value,
                            NewValue = value
                        });
                    }
                }
            }

            if (modifys.Any())
            {
                ConsoleLog.WriteLine("CONFIG_EDIT");
                ConsoleLog.TablePrint(modifys);
            }
        }

        class ConsoleLog
        {
            public static void TablePrint(object list)
            {

            }
            public static void WriteLine(params string[] write)
            {
                Console.WriteLine(string.Join(",", write));
            }
        }
    }
}