using System;
using System.Threading;
using filter_value.com;
using static filter_value.PublicKey;


namespace filter_value.datasource.redis
{
    public class redis_source
    {

        /// <summary>
        /// redis连接
        /// </summary>
        /// <param name="env"></param>
        public void RedisConnection(dynamic env)
        { 

            //循环redis获取探查数据
            CacheConfigurage.redis_password = GetConfig.Get("redis_password");
            CacheConfigurage.ConnectionString = GetConfig.Get("redis_host"); ;
            CacheConfigurage.redis_default_database = Convert.ToInt32(GetConfig.Get("redis_database"));

            var input = (string[])env.input();
            if (input != null)
            {
                while (true)
                {
                    var delay = (int)env.delay();

                    Thread.Sleep(delay);

                    foreach (var item in input)
                    {
                        env.exec(item);
                    }
                    if ((bool)env.complete_stop())
                    {
                        //每完成一次暂停一次
                        Console.WriteLine("you enable complete!");
                        Console.ReadKey();
                    }
                }
            }
        }

    }
}
