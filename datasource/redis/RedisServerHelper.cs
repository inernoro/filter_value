using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace filter_value.datasource.redis
{
    public static class RedisServerHelper
    { 
        #region Single Server
         

        public static IServer GetServer()
        {
            var end = RedisHelper.Manager.GetEndPoints().First();
            var server = RedisHelper.Manager.GetServer(end);
            return server;
        }
         

        private static IServer _server;
        private static  object _obj_lock = new object();

        private static IServer Server { 
            get
            { 
                if (_server == null)
                {
                    lock (_obj_lock)
                    {
                        if (_server == null)
                        {
                            _server = GetServer(); 
                        }
                    }
                }

                return _server;
            }
        }  


        public static Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.PingAsync(flags);
        }

        public static bool TryWait(Task task)
        {
            return Server.TryWait(task);
        }

        public static void Wait(Task task)
        {
            Server.Wait(task);
        }

        public static T Wait<T>(Task<T> task)
        {
            return Server.Wait(task);
        }

        public static void WaitAll(params Task[] tasks)
        {
            Server.WaitAll(tasks);
        }

        public static IConnectionMultiplexer Multiplexer => Server.Multiplexer;

        public static TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            return Server.Ping(flags);
        }

        public static void ClientKill(EndPoint endpoint, CommandFlags flags = CommandFlags.None)
        {
            Server.ClientKill(endpoint, flags);
        }

        public static Task ClientKillAsync(EndPoint endpoint, CommandFlags flags = CommandFlags.None)
        {
            return Server.ClientKillAsync(endpoint, flags);
        }

        public static long ClientKill(long? id = null, ClientType? clientType = null, EndPoint endpoint = null, bool skipMe = true,
            CommandFlags flags = CommandFlags.None)
        {
            return Server.ClientKill(id, clientType, endpoint, skipMe, flags);
        }

        public static Task<long> ClientKillAsync(long? id = null, ClientType? clientType = null, EndPoint endpoint = null, bool skipMe = true,
            CommandFlags flags = CommandFlags.None)
        {
            return Server.ClientKillAsync(id, clientType, endpoint, skipMe, flags);
        }

        public static ClientInfo[] ClientList(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClientList(flags);
        }

        public static Task<ClientInfo[]> ClientListAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClientListAsync(flags);
        }

        public static ClusterConfiguration ClusterNodes(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClusterNodes(flags);
        }

        public static Task<ClusterConfiguration> ClusterNodesAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClusterNodesAsync(flags);
        }

        public static string ClusterNodesRaw(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClusterNodesRaw(flags);
        }

        public static Task<string> ClusterNodesRawAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ClusterNodesRawAsync(flags);
        }

        public static KeyValuePair<string, string>[] ConfigGet(RedisValue pattern = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.ConfigGet(pattern, flags);
        }

        public static Task<KeyValuePair<string, string>[]> ConfigGetAsync(RedisValue pattern = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.ConfigGetAsync(pattern, flags);
        }

        public static void ConfigResetStatistics(CommandFlags flags = CommandFlags.None)
        {
            Server.ConfigResetStatistics(flags);
        }

        public static Task ConfigResetStatisticsAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ConfigResetStatisticsAsync(flags);
        }

        public static void ConfigRewrite(CommandFlags flags = CommandFlags.None)
        {
            Server.ConfigRewrite(flags);
        }

        public static Task ConfigRewriteAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ConfigRewriteAsync(flags);
        }

        public static void ConfigSet(RedisValue setting, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            Server.ConfigSet(setting, value, flags);
        }

        public static Task ConfigSetAsync(RedisValue setting, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            return Server.ConfigSetAsync(setting, value, flags);
        }

        public static long DatabaseSize(int database = -1, CommandFlags flags = CommandFlags.None)
        {
            return Server.DatabaseSize(database, flags);
        }

        public static Task<long> DatabaseSizeAsync(int database = -1, CommandFlags flags = CommandFlags.None)
        {
            return Server.DatabaseSizeAsync(database, flags);
        }

        public static RedisValue Echo(RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return Server.Echo(message, flags);
        }

        public static Task<RedisValue> EchoAsync(RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return Server.EchoAsync(message, flags);
        }

        public static RedisResult Execute(string command, params object[] args)
        {
            return Server.Execute(command, args);
        }

        public static RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return Server.Execute(command, args, flags);
        }

        public static Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            return Server.ExecuteAsync(command, args);
        }

        public static Task<RedisResult> ExecuteAsync(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return Server.ExecuteAsync(command, args, flags);
        }

        public static void FlushAllDatabases(CommandFlags flags = CommandFlags.None)
        {
            Server.FlushAllDatabases(flags);
        }

        public static Task FlushAllDatabasesAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.FlushAllDatabasesAsync(flags);
        }

        public static void FlushDatabase(int database = -1, CommandFlags flags = CommandFlags.None)
        {
            Server.FlushDatabase(database, flags);
        }

        public static Task FlushDatabaseAsync(int database = -1, CommandFlags flags = CommandFlags.None)
        {
            return Server.FlushDatabaseAsync(database, flags);
        }

        public static ServerCounters GetCounters()
        {
            return Server.GetCounters();
        }

        public static IGrouping<string, KeyValuePair<string, string>>[] Info(RedisValue section = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.Info(section, flags);
        }

        public static Task<IGrouping<string, KeyValuePair<string, string>>[]> InfoAsync(RedisValue section = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.InfoAsync(section, flags);
        }

        public static string InfoRaw(RedisValue section = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.InfoRaw(section, flags);
        }

        public static Task<string> InfoRawAsync(RedisValue section = new RedisValue(), CommandFlags flags = CommandFlags.None)
        {
            return Server.InfoRawAsync(section, flags);
        }

        public static IEnumerable<RedisKey> KeysScanner(int database, RedisValue pattern, int pageSize, CommandFlags flags)
        { 
            return Server.Keys(database, pattern, pageSize, flags);
        }

        public static string[] Keys(int database = -1, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return Server.Keys(database, pattern, pageSize, cursor, pageOffset, flags).Select(x=>x.ToString()).ToArray();
        }

        public static IAsyncEnumerable<RedisKey> KeysAsync(int database = -1, RedisValue pattern = new RedisValue(), int pageSize = 250,
            long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return Server.KeysAsync(database, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static DateTime LastSave(CommandFlags flags = CommandFlags.None)
        {
            return Server.LastSave(flags);
        }

        public static Task<DateTime> LastSaveAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.LastSaveAsync(flags);
        }

        public static void MakeMaster(ReplicationChangeOptions options, TextWriter log = null)
        {
            Server.MakeMaster(options, log);
        }

        public static void Save(SaveType type, CommandFlags flags = CommandFlags.None)
        {
            Server.Save(type, flags);
        }

        public static Task SaveAsync(SaveType type, CommandFlags flags = CommandFlags.None)
        {
            return Server.SaveAsync(type, flags);
        }

        public static bool ScriptExists(string script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptExists(script, flags);
        }

        public static bool ScriptExists(byte[] sha1, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptExists(sha1, flags);
        }

        public static Task<bool> ScriptExistsAsync(string script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptExistsAsync(script, flags);
        }

        public static Task<bool> ScriptExistsAsync(byte[] sha1, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptExistsAsync(sha1, flags);
        }

        public static void ScriptFlush(CommandFlags flags = CommandFlags.None)
        {
            Server.ScriptFlush(flags);
        }

        public static Task ScriptFlushAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptFlushAsync(flags);
        }

        public static byte[] ScriptLoad(string script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptLoad(script, flags);
        }

        public static LoadedLuaScript ScriptLoad(LuaScript script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptLoad(script, flags);
        }

        public static Task<byte[]> ScriptLoadAsync(string script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptLoadAsync(script, flags);
        }

        public static Task<LoadedLuaScript> ScriptLoadAsync(LuaScript script, CommandFlags flags = CommandFlags.None)
        {
            return Server.ScriptLoadAsync(script, flags);
        }

        public static void Shutdown(ShutdownMode shutdownMode = ShutdownMode.Default, CommandFlags flags = CommandFlags.None)
        {
            Server.Shutdown(shutdownMode, flags);
        }
         
        public static void ReplicaOf(EndPoint master, CommandFlags flags = CommandFlags.None)
        {
            Server.ReplicaOf(master, flags);
        }
         
        public static Task ReplicaOfAsync(EndPoint master, CommandFlags flags = CommandFlags.None)
        {
            return Server.ReplicaOfAsync(master, flags);
        }

        public static CommandTrace[] SlowlogGet(int count = 0, CommandFlags flags = CommandFlags.None)
        {
            return Server.SlowlogGet(count, flags);
        }

        public static Task<CommandTrace[]> SlowlogGetAsync(int count = 0, CommandFlags flags = CommandFlags.None)
        {
            return Server.SlowlogGetAsync(count, flags);
        }

        public static void SlowlogReset(CommandFlags flags = CommandFlags.None)
        {
            Server.SlowlogReset(flags);
        }

        public static Task SlowlogResetAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.SlowlogResetAsync(flags);
        }

        public static RedisChannel[] SubscriptionChannels(RedisChannel pattern = new RedisChannel(), CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionChannels(pattern, flags);
        }

        public static Task<RedisChannel[]> SubscriptionChannelsAsync(RedisChannel pattern = new RedisChannel(), CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionChannelsAsync(pattern, flags);
        }

        public static long SubscriptionPatternCount(CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionPatternCount(flags);
        }

        public static Task<long> SubscriptionPatternCountAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionPatternCountAsync(flags);
        }

        public static long SubscriptionSubscriberCount(RedisChannel channel, CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionSubscriberCount(channel, flags);
        }

        public static Task<long> SubscriptionSubscriberCountAsync(RedisChannel channel, CommandFlags flags = CommandFlags.None)
        {
            return Server.SubscriptionSubscriberCountAsync(channel, flags);
        }

        public static void SwapDatabases(int first, int second, CommandFlags flags = CommandFlags.None)
        {
            Server.SwapDatabases(first, second, flags);
        }

        public static Task SwapDatabasesAsync(int first, int second, CommandFlags flags = CommandFlags.None)
        {
            return Server.SwapDatabasesAsync(first, second, flags);
        }

        public static DateTime Time(CommandFlags flags = CommandFlags.None)
        {
            return Server.Time(flags);
        }

        public static Task<DateTime> TimeAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.TimeAsync(flags);
        }

        public static Task<string> LatencyDoctorAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyDoctorAsync(flags);
        }

        public static string LatencyDoctor(CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyDoctor(flags);
        }

        public static Task<long> LatencyResetAsync(string[] eventNames = null, CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyResetAsync(eventNames, flags);
        }

        public static long LatencyReset(string[] eventNames = null, CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyReset(eventNames, flags);
        }

        public static Task<LatencyHistoryEntry[]> LatencyHistoryAsync(string eventName, CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyHistoryAsync(eventName, flags);
        }

        public static LatencyHistoryEntry[] LatencyHistory(string eventName, CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyHistory(eventName, flags);
        }

        public static Task<LatencyLatestEntry[]> LatencyLatestAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyLatestAsync(flags);
        }

        public static LatencyLatestEntry[] LatencyLatest(CommandFlags flags = CommandFlags.None)
        {
            return Server.LatencyLatest(flags);
        }

        public static Task<string> MemoryDoctorAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryDoctorAsync(flags);
        }

        public static string MemoryDoctor(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryDoctor(flags);
        }

        public static Task MemoryPurgeAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryPurgeAsync(flags);
        }

        public static void MemoryPurge(CommandFlags flags = CommandFlags.None)
        {
            Server.MemoryPurge(flags);
        }

        public static Task<RedisResult> MemoryStatsAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryStatsAsync(flags);
        }

        public static RedisResult MemoryStats(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryStats(flags);
        }

        public static Task<string> MemoryAllocatorStatsAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryAllocatorStatsAsync(flags);
        }

        public static string MemoryAllocatorStats(CommandFlags flags = CommandFlags.None)
        {
            return Server.MemoryAllocatorStats(flags);
        }

        public static EndPoint SentinelGetMasterAddressByName(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetMasterAddressByName(serviceName, flags);
        }

        public static Task<EndPoint> SentinelGetMasterAddressByNameAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetMasterAddressByNameAsync(serviceName, flags);
        }

        public static EndPoint[] SentinelGetSentinelAddresses(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetSentinelAddresses(serviceName, flags);
        }

        public static Task<EndPoint[]> SentinelGetSentinelAddressesAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetSentinelAddressesAsync(serviceName, flags);
        }

        public static EndPoint[] SentinelGetReplicaAddresses(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetReplicaAddresses(serviceName, flags);
        }

        public static Task<EndPoint[]> SentinelGetReplicaAddressesAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelGetReplicaAddressesAsync(serviceName, flags);
        }

        public static KeyValuePair<string, string>[] SentinelMaster(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelMaster(serviceName, flags);
        }

        public static Task<KeyValuePair<string, string>[]> SentinelMasterAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelMasterAsync(serviceName, flags);
        }

        public static KeyValuePair<string, string>[][] SentinelMasters(CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelMasters(flags);
        }

        public static Task<KeyValuePair<string, string>[][]> SentinelMastersAsync(CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelMastersAsync(flags);
        }
         
        public static KeyValuePair<string, string>[][] SentinelReplicas(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelReplicas(serviceName, flags);
        }
         
        public static Task<KeyValuePair<string, string>[][]> SentinelReplicasAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelReplicasAsync(serviceName, flags);
        }

        public static void SentinelFailover(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            Server.SentinelFailover(serviceName, flags);
        }

        public static Task SentinelFailoverAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelFailoverAsync(serviceName, flags);
        }

        public static KeyValuePair<string, string>[][] SentinelSentinels(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelSentinels(serviceName, flags);
        }

        public static Task<KeyValuePair<string, string>[][]> SentinelSentinelsAsync(string serviceName, CommandFlags flags = CommandFlags.None)
        {
            return Server.SentinelSentinelsAsync(serviceName, flags);
        }

        public static ClusterConfiguration ClusterConfiguration => Server.ClusterConfiguration;

        public static EndPoint EndPoint => Server.EndPoint;

        public static RedisFeatures Features => Server.Features;

        public static bool IsConnected => Server.IsConnected;
         

        public static bool IsReplica => Server.IsReplica;
         
        public static bool AllowReplicaWrites
        {
            get => Server.AllowReplicaWrites;
            set => Server.AllowReplicaWrites = value;
        }

        public static ServerType ServerType => Server.ServerType;

        public static Version Version => Server.Version;

        public static int DatabaseCount => Server.DatabaseCount;

        #endregion
    }
}