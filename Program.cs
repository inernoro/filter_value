using Neo.IronLua;
using System;
using filter_value.com;
using filter_value.datasource.redis;
using static filter_value.PublicKey;

namespace filter_value
{
    public class Program
    {

        static void Main(string[] args)
        { 
            //加载配置项
            GetConfig.PerformBadly();

            Args = args;
            var execute = GetSource();
            var lua = new Lua();
            LuaGlobal env = lua.CreateEnvironment();
            var file = Environment.CurrentDirectory + "\\script\\main.lua";
            env.DoChunk(file);
            dynamic en = env;
            execute(en);
        }

        public static Action<dynamic> GetSource()
        {
            
            var conf = find_value("-r", "cmd");
            Action<dynamic> func = null;
            switch (conf)
            {
                case "cmd":
                    func = datasource.command.command_source.Command;
                    break;

                case "redis":
                    redis_source r = new redis_source();
                    func = r.RedisConnection;
                    break;
                case "mssql":
                    break;
                default:
                    throw new Exception("没有找到该入点");
            }
            return func;
        }



    }
}