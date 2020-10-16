using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace filter_value.datasource.redis
{
    public static class RedisHelper
    {
        private static ConnectionMultiplexer _connectionMultiplexer;

        private static readonly object Locker = new object();


        private static readonly object Lock = new object();


        public static ConnectionMultiplexer Manager
        {
            get
            {
                if (_connectionMultiplexer == null)
                {
                    lock (Locker)
                    {
                        if (_connectionMultiplexer != null) return _connectionMultiplexer;
                        _connectionMultiplexer = ConnectionMultiplexer.Connect(new ConfigurationOptions
                        {
                            AbortOnConnectFail = false,
                            AllowAdmin = true,
                            ConnectTimeout = 45000,
                            SyncTimeout = 45000,
                            EndPoints = { CacheConfigurage.ConnectionString },
                            Password = CacheConfigurage.redis_password,
                            DefaultDatabase = CacheConfigurage.redis_default_database
                        });
                        return _connectionMultiplexer;
                    }
                }
                return _connectionMultiplexer;
            }
        }



        public static IDatabase GetDatabase()
        {
            return Manager.GetDatabase();
        }


        private static IDatabase Redis => GetDatabase();


        public static Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            return Redis.PingAsync(flags);
        }

        public static bool TryWait(Task task)
        {
            return Redis.TryWait(task);
        }

        public static void Wait(Task task)
        {
            Redis.Wait(task);
        }

        public static T Wait<T>(Task<T> task)
        {
            return Redis.Wait(task);
        }

        public static void WaitAll(params Task[] tasks)
        {
            Redis.WaitAll(tasks);
        }

        private static IConnectionMultiplexer Multiplexer => Redis.Multiplexer;

        public static TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            return Redis.Ping(flags);
        }

        public static bool IsConnected(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.IsConnected(key, flags);
        }

        public static Task KeyMigrateAsync(string key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyMigrateAsync(key, toServer, toDatabase, timeoutMilliseconds, migrateOptions, flags);
        }

        public static Task<RedisValue> DebugObjectAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.DebugObjectAsync(key, flags);
        }

        public static Task<bool> GeoAddAsync(string key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAddAsync(key, longitude, latitude, member, flags);
        }

        public static Task<bool> GeoAddAsync(string key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAddAsync(key, value, flags);
        }

        public static Task<long> GeoAddAsync(string key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAddAsync(key, values, flags);
        }

        public static Task<bool> GeoRemoveAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRemoveAsync(key, member, flags);
        }

        public static Task<double?> GeoDistanceAsync(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoDistanceAsync(key, member1, member2, unit, flags);
        }

        public static Task<string[]> GeoHashAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoHashAsync(key, members, flags);
        }

        public static Task<string> GeoHashAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoHashAsync(key, member, flags);
        }

        public static Task<GeoPosition?[]> GeoPositionAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoPositionAsync(key, members, flags);
        }

        public static Task<GeoPosition?> GeoPositionAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoPositionAsync(key, member, flags);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRadiusAsync(key, member, radius, unit, count, order, options, flags);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRadiusAsync(key, longitude, latitude, radius, unit, count, order, options, flags);
        }

        public static Task<long> HashDecrementAsync(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDecrementAsync(key, hashField, value, flags);
        }

        public static Task<double> HashDecrementAsync(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDecrementAsync(key, hashField, value, flags);
        }

        public static Task<bool> HashDeleteAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDeleteAsync(key, hashField, flags);
        }

        public static Task<long> HashDeleteAsync(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDeleteAsync(key, hashFields, flags);
        }

        public static Task<bool> HashExistsAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashExistsAsync(key, hashField, flags);
        }

        public static Task<RedisValue> HashGetAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetAsync(key, hashField, flags);
        }

        public static Task<Lease<byte>> HashGetLeaseAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetLeaseAsync(key, hashField, flags);
        }

        public static Task<RedisValue[]> HashGetAsync(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetAsync(key, hashFields, flags);
        }

        public static Task<HashEntry[]> HashGetAllAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetAllAsync(key, flags);
        }

        public static Task<long> HashIncrementAsync(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashIncrementAsync(key, hashField, value, flags);
        }

        public static Task<double> HashIncrementAsync(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashIncrementAsync(key, hashField, value, flags);
        }

        public static Task<RedisValue[]> HashKeysAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashKeysAsync(key, flags);
        }

        public static Task<long> HashLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashLengthAsync(key, flags);
        }

        public static Task HashSetAsync(string key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashSetAsync(key, hashFields, flags);
        }

        public static Task<bool> HashSetAsync(string key, RedisValue hashField, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashSetAsync(key, hashField, value, when, flags);
        }

        public static Task<RedisValue[]> HashValuesAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashValuesAsync(key, flags);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogAddAsync(key, value, flags);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogAddAsync(key, values, flags);
        }

        public static Task<long> HyperLogLogLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogLengthAsync(key, flags);
        }

        public static Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogLengthAsync(keys, flags);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogMergeAsync(destination, first, second, flags);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogMergeAsync(destination, sourceKeys, flags);
        }


        public static Task<bool> KeyDeleteAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDeleteAsync(key, flags);
        }

        public static Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDeleteAsync(keys, flags);
        }

        public static Task<byte[]> KeyDumpAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDumpAsync(key, flags);
        }

        public static Task<bool> KeyExistsAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExistsAsync(key, flags);
        }

        public static Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExistsAsync(keys, flags);
        }

        public static Task<bool> KeyExpireAsync(string key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExpireAsync(key, expiry, flags);
        }

        public static Task<bool> KeyExpireAsync(string key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExpireAsync(key, expiry, flags);
        }

        public static Task<TimeSpan?> KeyIdleTimeAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyIdleTimeAsync(key, flags);
        }

        public static Task<bool> KeyMoveAsync(string key, int database, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyMoveAsync(key, database, flags);
        }

        public static Task<bool> KeyPersistAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyPersistAsync(key, flags);
        }

        public static Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyRandomAsync(flags);
        }

        public static Task<bool> KeyRenameAsync(string key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyRenameAsync(key, newKey, when, flags);
        }

        public static Task KeyRestoreAsync(string key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyRestoreAsync(key, value, expiry, flags);
        }

        public static Task<TimeSpan?> KeyTimeToLiveAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyTimeToLiveAsync(key, flags);
        }

        public static Task<RedisType> KeyTypeAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyTypeAsync(key, flags);
        }

        public static Task<RedisValue> ListGetByIndexAsync(string key, long index, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListGetByIndexAsync(key, index, flags);
        }

        public static Task<long> ListInsertAfterAsync(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListInsertAfterAsync(key, pivot, value, flags);
        }

        public static Task<long> ListInsertBeforeAsync(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListInsertBeforeAsync(key, pivot, value, flags);
        }

        public static Task<RedisValue> ListLeftPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPopAsync(key, flags);
        }

        public static Task<long> ListLeftPushAsync(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPushAsync(key, value, when, flags);
        }

        public static Task<long> ListLeftPushAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPushAsync(key, values, flags);
        }

        public static Task<long> ListLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLengthAsync(key, flags);
        }

        public static Task<RedisValue[]> ListRangeAsync(string key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRangeAsync(key, start, stop, flags);
        }

        public static Task<long> ListRemoveAsync(string key, string value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRemoveAsync(key, value, count, flags);
        }

        public static Task<RedisValue> ListRightPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPopAsync(key, flags);
        }

        public static Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPopLeftPushAsync(source, destination, flags);
        }

        public static Task<long> ListRightPushAsync(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPushAsync(key, value, when, flags);
        }

        public static Task<long> ListRightPushAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPushAsync(key, values, flags);
        }

        public static Task ListSetByIndexAsync(string key, long index, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListSetByIndexAsync(key, index, value, flags);
        }

        public static Task ListTrimAsync(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListTrimAsync(key, start, stop, flags);
        }

        public static Task<bool> LockExtendAsync(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockExtendAsync(key, value, expiry, flags);
        }

        public static Task<RedisValue> LockQueryAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockQueryAsync(key, flags);
        }

        public static Task<bool> LockReleaseAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockReleaseAsync(key, value, flags);
        }

        public static Task<bool> LockTakeAsync(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockTakeAsync(key, value, expiry, flags);
        }

        public static Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return Redis.PublishAsync(channel, message, flags);
        }

        public static Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            return Redis.ExecuteAsync(command, args);
        }

        public static Task<RedisResult> ExecuteAsync(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ExecuteAsync(command, args, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluateAsync(script, keys, values, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluateAsync(hash, keys, values, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluateAsync(script, parameters, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluateAsync(script, parameters, flags);
        }

        public static Task<bool> SetAddAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetAddAsync(key, value, flags);
        }

        public static Task<long> SetAddAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetAddAsync(key, values, flags);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAsync(operation, first, second, flags);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAsync(operation, keys, flags);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAndStoreAsync(operation, destination, first, second, flags);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAndStoreAsync(operation, destination, keys, flags);
        }

        public static Task<bool> SetContainsAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetContainsAsync(key, value, flags);
        }

        public static Task<long> SetLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetLengthAsync(key, flags);
        }

        public static Task<RedisValue[]> SetMembersAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetMembersAsync(key, flags);
        }

        public static Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetMoveAsync(source, destination, value, flags);
        }

        public static Task<RedisValue> SetPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetPopAsync(key, flags);
        }

        public static Task<RedisValue[]> SetPopAsync(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetPopAsync(key, count, flags);
        }

        public static Task<RedisValue> SetRandomMemberAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRandomMemberAsync(key, flags);
        }

        public static Task<RedisValue[]> SetRandomMembersAsync(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRandomMembersAsync(key, count, flags);
        }

        public static Task<bool> SetRemoveAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRemoveAsync(key, value, flags);
        }

        public static Task<long> SetRemoveAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRemoveAsync(key, values, flags);
        }
 
        public static Task<RedisValue[]> SortAsync(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortAsync(key, skip, take, order, sortType, @by, get, flags);
        }

        public static Task<long> SortAndStoreAsync(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortAndStoreAsync(destination, key, skip, take, order, sortType, @by, get, flags);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, CommandFlags flags)
        {
            return Redis.SortedSetAddAsync(key, member, score, flags);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetAddAsync(key, member, score, when, flags);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return Redis.SortedSetAddAsync(key, values, flags);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetAddAsync(key, values, when, flags);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetCombineAndStoreAsync(operation, destination, first, second, aggregate, flags);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys,
            double[] weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetCombineAndStoreAsync(operation, destination, keys, weights, aggregate, flags);
        }

        public static Task<double> SortedSetDecrementAsync(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetDecrementAsync(key, member, value, flags);
        }

        public static Task<double> SortedSetIncrementAsync(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetIncrementAsync(key, member, value, flags);
        }

        public static Task<long> SortedSetLengthAsync(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetLengthAsync(key, min, max, exclude, flags);
        }

        public static Task<long> SortedSetLengthByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetLengthByValueAsync(key, min, max, exclude, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByRankAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByRankAsync(key, start, stop, order, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByRankWithScoresAsync(key, start, stop, order, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByScoreAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None,
            Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByScoreAsync(key, start, stop, exclude, order, skip, take, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByScoreWithScoresAsync(key, start, stop, exclude, order, skip, take, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByValueAsync(key, min, max, exclude, skip, take, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByValueAsync(key, min, max, exclude, order, skip, take, flags);
        }

        public static Task<long?> SortedSetRankAsync(string key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRankAsync(key, member, order, flags);
        }

        public static Task<bool> SortedSetRemoveAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveAsync(key, member, flags);
        }

        public static Task<long> SortedSetRemoveAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveAsync(key, members, flags);
        }

        public static Task<long> SortedSetRemoveRangeByRankAsync(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByRankAsync(key, start, stop, flags);
        }

        public static Task<long> SortedSetRemoveRangeByScoreAsync(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByScoreAsync(key, start, stop, exclude, flags);
        }

        public static Task<long> SortedSetRemoveRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByValueAsync(key, min, max, exclude, flags);
        }

        public static Task<double?> SortedSetScoreAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetScoreAsync(key, member, flags);
        }

        public static Task<SortedSetEntry?> SortedSetPopAsync(string key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetPopAsync(key, order, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetPopAsync(string key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetPopAsync(key, count, order, flags);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAcknowledgeAsync(key, groupName, messageId, flags);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAcknowledgeAsync(key, groupName, messageIds, flags);
        }

        public static Task<RedisValue> StreamAddAsync(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAddAsync(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<RedisValue> StreamAddAsync(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAddAsync(key, streamPairs, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<StreamEntry[]> StreamClaimAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamClaimAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static Task<RedisValue[]> StreamClaimIdsOnlyAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamClaimIdsOnlyAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static Task<bool> StreamConsumerGroupSetPositionAsync(string key, RedisValue groupName, RedisValue position,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamConsumerGroupSetPositionAsync(key, groupName, position, flags);
        }

        public static Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamConsumerInfoAsync(key, groupName, flags);
        }

        public static Task<bool> StreamCreateConsumerGroupAsync(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamCreateConsumerGroupAsync(key, groupName, position, flags);
        }

        public static Task<long> StreamDeleteAsync(string key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDeleteAsync(key, messageIds, flags);
        }

        public static Task<long> StreamDeleteConsumerAsync(string key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDeleteConsumerAsync(key, groupName, consumerName, flags);
        }

        public static Task<bool> StreamDeleteConsumerGroupAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDeleteConsumerGroupAsync(key, groupName, flags);
        }

        public static Task<StreamGroupInfo[]> StreamGroupInfoAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamGroupInfoAsync(key, flags);
        }

        public static Task<StreamInfo> StreamInfoAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamInfoAsync(key, flags);
        }

        public static Task<long> StreamLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamLengthAsync(key, flags);
        }

        public static Task<StreamPendingInfo> StreamPendingAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamPendingAsync(key, groupName, flags);
        }

        public static Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamPendingMessagesAsync(key, groupName, count, consumerName, minId, maxId, flags);
        }

        public static Task<StreamEntry[]> StreamRangeAsync(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamRangeAsync(key, minId, maxId, count, messageOrder, flags);
        }

        public static Task<StreamEntry[]> StreamReadAsync(string key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadAsync(key, position, count, flags);
        }

        public static Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadAsync(streamPositions, countPerStream, flags);
        }

        public static Task<StreamEntry[]> StreamReadGroupAsync(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadGroupAsync(key, groupName, consumerName, position, count, flags);
        }

        public static Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadGroupAsync(streamPositions, groupName, consumerName, countPerStream, flags);
        }

        public static Task<long> StreamTrimAsync(string key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamTrimAsync(key, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<long> StringAppendAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringAppendAsync(key, value, flags);
        }

        public static Task<long> StringBitCountAsync(string key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitCountAsync(key, start, end, flags);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitOperationAsync(operation, destination, first, second, flags);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitOperationAsync(operation, destination, keys, flags);
        }

        public static Task<long> StringBitPositionAsync(string key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitPositionAsync(key, bit, start, end, flags);
        }

        public static Task<long> StringDecrementAsync(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringDecrementAsync(key, value, flags);
        }

        public static Task<double> StringDecrementAsync(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringDecrementAsync(key, value, flags);
        }

        public static Task<RedisValue> StringGetAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetAsync(key, flags);
        }

        public static Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetAsync(keys, flags);
        }

        public static Task<Lease<byte>> StringGetLeaseAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetLeaseAsync(key, flags);
        }

        public static Task<bool> StringGetBitAsync(string key, long offset, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetBitAsync(key, offset, flags);
        }

        public static Task<RedisValue> StringGetRangeAsync(string key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetRangeAsync(key, start, end, flags);
        }

        public static Task<RedisValue> StringGetSetAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetSetAsync(key, value, flags);
        }

        public static Task<RedisValueWithExpiry> StringGetWithExpiryAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetWithExpiryAsync(key, flags);
        }

        public static Task<long> StringIncrementAsync(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringIncrementAsync(key, value, flags);
        }

        public static Task<double> StringIncrementAsync(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringIncrementAsync(key, value, flags);
        }

        public static Task<long> StringLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringLengthAsync(key, flags);
        }

        public static Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = null, When when = When.Always,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetAsync(key, value, expiry, when, flags);
        }

        public static Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetAsync(values, when, flags);
        }

        public static Task<bool> StringSetBitAsync(string key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetBitAsync(key, offset, bit, flags);
        }

        public static Task<RedisValue> StringSetRangeAsync(string key, long offset, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetRangeAsync(key, offset, value, flags);
        }

        public static IBatch CreateBatch(object asyncState = null)
        {
            return Redis.CreateBatch(asyncState);
        }

        public static ITransaction CreateTransaction(object asyncState = null)
        {
            return Redis.CreateTransaction(asyncState);
        }

        public static void KeyMigrate(string key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            Redis.KeyMigrate(key, toServer, toDatabase, timeoutMilliseconds, migrateOptions, flags);
        }

        public static RedisValue DebugObject(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.DebugObject(key, flags);
        }

        public static bool GeoAdd(string key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAdd(key, longitude, latitude, member, flags);
        }

        public static bool GeoAdd(string key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAdd(key, value, flags);
        }

        public static long GeoAdd(string key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoAdd(key, values, flags);
        }

        public static bool GeoRemove(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRemove(key, member, flags);
        }

        public static double? GeoDistance(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoDistance(key, member1, member2, unit, flags);
        }

        public static string[] GeoHash(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoHash(key, members, flags);
        }

        public static string GeoHash(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoHash(key, member, flags);
        }

        public static GeoPosition?[] GeoPosition(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoPosition(key, members, flags);
        }

        public static GeoPosition? GeoPosition(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoPosition(key, member, flags);
        }

        public static GeoRadiusResult[] GeoRadius(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRadius(key, member, radius, unit, count, order, options, flags);
        }

        public static GeoRadiusResult[] GeoRadius(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return Redis.GeoRadius(key, longitude, latitude, radius, unit, count, order, options, flags);
        }

        public static long HashDecrement(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDecrement(key, hashField, value, flags);
        }

        public static double HashDecrement(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDecrement(key, hashField, value, flags);
        }

        public static bool HashDelete(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDelete(key, hashField, flags);
        }

        public static long HashDelete(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashDelete(key, hashFields, flags);
        }

        public static bool HashExists(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashExists(key, hashField, flags);
        }

        public static RedisValue HashGet(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGet(key, hashField, flags);
        }

        public static Lease<byte> HashGetLease(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetLease(key, hashField, flags);
        }

        public static RedisValue[] HashGet(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGet(key, hashFields, flags);
        }

        public static HashEntry[] HashGetAll(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashGetAll(key, flags);
        }

        public static long HashIncrement(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashIncrement(key, hashField, value, flags);
        }

        public static double HashIncrement(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashIncrement(key, hashField, value, flags);
        }

        public static RedisValue[] HashKeys(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashKeys(key, flags);
        }

        public static long HashLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashLength(key, flags);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return Redis.HashScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static void HashSet(string key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            Redis.HashSet(key, hashFields, flags);
        }

        public static bool HashSet(string key, RedisValue hashField, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashSet(key, hashField, value, when, flags);
        }

        public static RedisValue[] HashValues(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HashValues(key, flags);
        }

        public static bool HyperLogLogAdd(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogAdd(key, value, flags);
        }

        public static bool HyperLogLogAdd(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogAdd(key, values, flags);
        }

        public static long HyperLogLogLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogLength(key, flags);
        }

        public static long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.HyperLogLogLength(keys, flags);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            Redis.HyperLogLogMerge(destination, first, second, flags);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            Redis.HyperLogLogMerge(destination, sourceKeys, flags);
        }

        public static bool KeyDelete(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDelete(key, flags);
        }

        public static long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDelete(keys, flags);
        }

        public static byte[] KeyDump(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyDump(key, flags);
        }

        public static bool KeyExists(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExists(key, flags);
        }

        public static long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExists(keys, flags);
        }

        public static bool KeyExpire(string key, double expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExpire(key, DateTime.Now.AddSeconds(expiry), flags);
        }

        public static bool KeyExpire(string key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExpire(key, expiry, flags);
        }

        public static bool KeyExpire(string key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyExpire(key, expiry, flags);
        }

        public static TimeSpan? KeyIdleTime(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyIdleTime(key, flags);
        }

        public static bool KeyMove(string key, int database, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyMove(key, database, flags);
        }

        public static bool KeyPersist(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyPersist(key, flags);
        }

        public static string keyRandom(CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyRandom(flags);
        }

        public static bool KeyRename(string key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyRename(key, newKey, when, flags);
        }

        public static void KeyRestore(string key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            Redis.KeyRestore(key, value, expiry, flags);
        }

        public static TimeSpan? KeyTimeToLive(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyTimeToLive(key, flags);
        }

        public static RedisType KeyType(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.KeyType(key, flags);
        }

        public static RedisValue ListGetByIndex(string key, long index, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListGetByIndex(key, index, flags);
        }

        public static long ListInsertAfter(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListInsertAfter(key, pivot, value, flags);
        }

        public static long ListInsertBefore(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListInsertBefore(key, pivot, value, flags);
        }

        public static RedisValue ListLeftPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPop(key, flags);
        }

        public static long ListLeftPush(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPush(key, value, when, flags);
        }

        public static long ListLeftPush(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLeftPush(key, values, flags);
        }

        public static long ListLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListLength(key, flags);
        }

        public static RedisValue[] ListRange(string key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRange(key, start, stop, flags);
        }

        public static long ListRemove(string key, string value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRemove(key, value, count, flags);
        }

        public static RedisValue ListRightPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPop(key, flags);
        }

        public static RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPopLeftPush(source, destination, flags);
        }

        public static long ListRightPush(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPush(key, value, when, flags);
        }

        public static long ListRightPush(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ListRightPush(key, values, flags);
        }

        public static void ListSetByIndex(string key, long index, string value, CommandFlags flags = CommandFlags.None)
        {
            Redis.ListSetByIndex(key, index, value, flags);
        }

        public static void ListTrim(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            Redis.ListTrim(key, start, stop, flags);
        }

        public static bool LockExtend(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockExtend(key, value, expiry, flags);
        }

        public static RedisValue LockQuery(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockQuery(key, flags);
        }

        public static bool LockRelease(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockRelease(key, value, flags);
        }

        public static bool LockTake(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return Redis.LockTake(key, value, expiry, flags);
        }

        public static long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return Redis.Publish(channel, message, flags);
        }

        public static RedisResult Execute(string command, params object[] args)
        {
            return Redis.Execute(command, args);
        }

        public static RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return Redis.Execute(command, args, flags);
        }

        public static RedisResult ScriptEvaluate(string script, RedisKey[] keys = null, RedisValue[] values = null,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluate(script, keys, values, flags);
        }

        public static RedisResult ScriptEvaluate(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluate(hash, keys, values, flags);
        }

        public static RedisResult ScriptEvaluate(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluate(script, parameters, flags);
        }

        public static RedisResult ScriptEvaluate(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.ScriptEvaluate(script, parameters, flags);
        }

        public static bool SetAdd(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetAdd(key, value, flags);
        }

        public static long SetAdd(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetAdd(key, values, flags);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombine(operation, first, second, flags);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombine(operation, keys, flags);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAndStore(operation, destination, first, second, flags);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetCombineAndStore(operation, destination, keys, flags);
        }

        public static bool SetContains(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetContains(key, value, flags);
        }

        public static long SetLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetLength(key, flags);
        }

        public static RedisValue[] SetMembers(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetMembers(key, flags);
        }

        public static bool SetMove(RedisKey source, RedisKey destination, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetMove(source, destination, value, flags);
        }

        public static RedisValue SetPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetPop(key, flags);
        }

        public static RedisValue[] SetPop(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetPop(key, count, flags);
        }

        public static RedisValue SetRandomMember(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRandomMember(key, flags);
        }

        public static RedisValue[] SetRandomMembers(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRandomMembers(key, count, flags);
        }

        public static bool SetRemove(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRemove(key, value, flags);
        }

        public static long SetRemove(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetRemove(key, values, flags);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return Redis.SetScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SetScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static RedisValue[] Sort(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.Sort(key, skip, take, order, sortType, @by, get, flags);
        }

        public static long SortAndStore(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortAndStore(destination, key, skip, take, order, sortType, @by, get, flags);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, CommandFlags flags)
        {
            return Redis.SortedSetAdd(key, member, score, flags);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetAdd(key, member, score, when, flags);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return Redis.SortedSetAdd(key, values, flags);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetAdd(key, values, when, flags);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetCombineAndStore(operation, destination, first, second, aggregate, flags);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[] weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetCombineAndStore(operation, destination, keys, weights, aggregate, flags);
        }

        public static double SortedSetDecrement(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetDecrement(key, member, value, flags);
        }

        public static double SortedSetIncrement(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetIncrement(key, member, value, flags);
        }

        public static long SortedSetLength(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetLength(key, min, max, exclude, flags);
        }

        public static long SortedSetLengthByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetLengthByValue(key, min, max, exclude, flags);
        }

        public static RedisValue[] SortedSetRangeByRank(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByRank(key, start, stop, order, flags);
        }

        public static SortedSetEntry[] SortedSetRangeByRankWithScores(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByRankWithScores(key, start, stop, order, flags);
        }

        public static RedisValue[] SortedSetRangeByScore(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByScore(key, start, stop, exclude, order, skip, take, flags);
        }

        public static SortedSetEntry[] SortedSetRangeByScoreWithScores(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByScoreWithScores(key, start, stop, exclude, order, skip, take, flags);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByValue(key, min, max, exclude, skip, take, flags);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRangeByValue(key, min, max, exclude, order, skip, take, flags);
        }

        public static long? SortedSetRank(string key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRank(key, member, order, flags);
        }

        public static bool SortedSetRemove(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemove(key, member, flags);
        }

        public static long SortedSetRemove(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemove(key, members, flags);
        }

        public static long SortedSetRemoveRangeByRank(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByRank(key, start, stop, flags);
        }

        public static long SortedSetRemoveRangeByScore(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByScore(key, start, stop, exclude, flags);
        }

        public static long SortedSetRemoveRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetRemoveRangeByValue(key, min, max, exclude, flags);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return Redis.SortedSetScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static double? SortedSetScore(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetScore(key, member, flags);
        }

        public static SortedSetEntry? SortedSetPop(string key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetPop(key, order, flags);
        }

        public static SortedSetEntry[] SortedSetPop(string key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.SortedSetPop(key, count, order, flags);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAcknowledge(key, groupName, messageId, flags);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAcknowledge(key, groupName, messageIds, flags);
        }

        public static RedisValue StreamAdd(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAdd(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static RedisValue StreamAdd(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamAdd(key, streamPairs, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static StreamEntry[] StreamClaim(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamClaim(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static RedisValue[] StreamClaimIdsOnly(string key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamClaimIdsOnly(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static bool StreamConsumerGroupSetPosition(string key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamConsumerGroupSetPosition(key, groupName, position, flags);
        }

        public static StreamConsumerInfo[] StreamConsumerInfo(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamConsumerInfo(key, groupName, flags);
        }

        public static bool StreamCreateConsumerGroup(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamCreateConsumerGroup(key, groupName, position, flags);
        }

        public static long StreamDelete(string key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDelete(key, messageIds, flags);
        }

        public static long StreamDeleteConsumer(string key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDeleteConsumer(key, groupName, consumerName, flags);
        }

        public static bool StreamDeleteConsumerGroup(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamDeleteConsumerGroup(key, groupName, flags);
        }

        public static StreamGroupInfo[] StreamGroupInfo(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamGroupInfo(key, flags);
        }

        public static StreamInfo StreamInfo(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamInfo(key, flags);
        }

        public static long StreamLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamLength(key, flags);
        }

        public static StreamPendingInfo StreamPending(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamPending(key, groupName, flags);
        }

        public static StreamPendingMessageInfo[] StreamPendingMessages(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamPendingMessages(key, groupName, count, consumerName, minId, maxId, flags);
        }

        public static StreamEntry[] StreamRange(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamRange(key, minId, maxId, count, messageOrder, flags);
        }

        public static StreamEntry[] StreamRead(string key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamRead(key, position, count, flags);
        }

        public static RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamRead(streamPositions, countPerStream, flags);
        }

        public static StreamEntry[] StreamReadGroup(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadGroup(key, groupName, consumerName, position, count, flags);
        }

        public static RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamReadGroup(streamPositions, groupName, consumerName, countPerStream, flags);
        }

        public static long StreamTrim(string key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StreamTrim(key, maxLength, useApproximateMaxLength, flags);
        }

        public static long StringAppend(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringAppend(key, value, flags);
        }

        public static long StringBitCount(string key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitCount(key, start, end, flags);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitOperation(operation, destination, first, second, flags);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitOperation(operation, destination, keys, flags);
        }

        public static long StringBitPosition(string key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringBitPosition(key, bit, start, end, flags);
        }

        public static long StringDecrement(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringDecrement(key, value, flags);
        }

        public static double StringDecrement(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringDecrement(key, value, flags);
        }

        public static RedisValue StringGet(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGet(key, flags);
        }

        public static RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGet(keys, flags);
        }

        public static Lease<byte> StringGetLease(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetLease(key, flags);
        }

        public static bool StringGetBit(string key, long offset, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetBit(key, offset, flags);
        }

        public static RedisValue StringGetRange(string key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetRange(key, start, end, flags);
        }

        public static RedisValue StringGetSet(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetSet(key, value, flags);
        }

        public static RedisValueWithExpiry StringGetWithExpiry(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringGetWithExpiry(key, flags);
        }

        public static long StringIncrement(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringIncrement(key, value, flags);
        }

        public static double StringIncrement(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringIncrement(key, value, flags);
        }

        public static long StringLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringLength(key, flags);
        }
        public static bool StringSet(string key, string value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSet(key, value, expiry, when, flags);
        }

        public static bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSet(values, when, flags);
        }

        public static bool StringSetBit(string key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetBit(key, offset, bit, flags);
        }

        public static RedisValue StringSetRange(string key, long offset, string value, CommandFlags flags = CommandFlags.None)
        {
            return Redis.StringSetRange(key, offset, value, flags);
        }

        #region  



        #endregion
    }
}