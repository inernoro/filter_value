using System;
using System.Collections.Generic;
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

        private static IDatabase _redis => GetDatabase();


        public static Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            return _redis.PingAsync(flags);
        }

        public static bool TryWait(Task task)
        {
            return _redis.TryWait(task);
        }

        public static void Wait(Task task)
        {
            _redis.Wait(task);
        }

        public static T Wait<T>(Task<T> task)
        {
            return _redis.Wait(task);
        }

        public static void WaitAll(params Task[] tasks)
        {
            _redis.WaitAll(tasks);
        }

        private static IConnectionMultiplexer Multiplexer => _redis.Multiplexer;

        public static TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            return _redis.Ping(flags);
        }

        public static bool IsConnected(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.IsConnected(key, flags);
        }

        public static Task KeyMigrateAsync(string key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyMigrateAsync(key, toServer, toDatabase, timeoutMilliseconds, migrateOptions, flags);
        }

        public static Task<RedisValue> DebugObjectAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.DebugObjectAsync(key, flags);
        }

        public static Task<bool> GeoAddAsync(string key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAddAsync(key, longitude, latitude, member, flags);
        }

        public static Task<bool> GeoAddAsync(string key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAddAsync(key, value, flags);
        }

        public static Task<long> GeoAddAsync(string key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAddAsync(key, values, flags);
        }

        public static Task<bool> GeoRemoveAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRemoveAsync(key, member, flags);
        }

        public static Task<double?> GeoDistanceAsync(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoDistanceAsync(key, member1, member2, unit, flags);
        }

        public static Task<string[]> GeoHashAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoHashAsync(key, members, flags);
        }

        public static Task<string> GeoHashAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoHashAsync(key, member, flags);
        }

        public static Task<GeoPosition?[]> GeoPositionAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoPositionAsync(key, members, flags);
        }

        public static Task<GeoPosition?> GeoPositionAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoPositionAsync(key, member, flags);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRadiusAsync(key, member, radius, unit, count, order, options, flags);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRadiusAsync(key, longitude, latitude, radius, unit, count, order, options, flags);
        }

        public static Task<long> HashDecrementAsync(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDecrementAsync(key, hashField, value, flags);
        }

        public static Task<double> HashDecrementAsync(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDecrementAsync(key, hashField, value, flags);
        }

        public static Task<bool> HashDeleteAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDeleteAsync(key, hashField, flags);
        }

        public static Task<long> HashDeleteAsync(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDeleteAsync(key, hashFields, flags);
        }

        public static Task<bool> HashExistsAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashExistsAsync(key, hashField, flags);
        }

        public static Task<RedisValue> HashGetAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetAsync(key, hashField, flags);
        }

        public static Task<Lease<byte>> HashGetLeaseAsync(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetLeaseAsync(key, hashField, flags);
        }

        public static Task<RedisValue[]> HashGetAsync(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetAsync(key, hashFields, flags);
        }

        public static Task<HashEntry[]> HashGetAllAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetAllAsync(key, flags);
        }

        public static Task<long> HashIncrementAsync(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashIncrementAsync(key, hashField, value, flags);
        }

        public static Task<double> HashIncrementAsync(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashIncrementAsync(key, hashField, value, flags);
        }

        public static Task<RedisValue[]> HashKeysAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashKeysAsync(key, flags);
        }

        public static Task<long> HashLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashLengthAsync(key, flags);
        }

        public static Task HashSetAsync(string key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashSetAsync(key, hashFields, flags);
        }

        public static Task<bool> HashSetAsync(string key, RedisValue hashField, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashSetAsync(key, hashField, value, when, flags);
        }

        public static Task<RedisValue[]> HashValuesAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashValuesAsync(key, flags);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogAddAsync(key, value, flags);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogAddAsync(key, values, flags);
        }

        public static Task<long> HyperLogLogLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogLengthAsync(key, flags);
        }

        public static Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogLengthAsync(keys, flags);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogMergeAsync(destination, first, second, flags);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogMergeAsync(destination, sourceKeys, flags);
        }


        public static Task<bool> KeyDeleteAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDeleteAsync(key, flags);
        }

        public static Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDeleteAsync(keys, flags);
        }

        public static Task<byte[]> KeyDumpAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDumpAsync(key, flags);
        }

        public static Task<bool> KeyExistsAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExistsAsync(key, flags);
        }

        public static Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExistsAsync(keys, flags);
        }

        public static Task<bool> KeyExpireAsync(string key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExpireAsync(key, expiry, flags);
        }

        public static Task<bool> KeyExpireAsync(string key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExpireAsync(key, expiry, flags);
        }

        public static Task<TimeSpan?> KeyIdleTimeAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyIdleTimeAsync(key, flags);
        }

        public static Task<bool> KeyMoveAsync(string key, int database, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyMoveAsync(key, database, flags);
        }

        public static Task<bool> KeyPersistAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyPersistAsync(key, flags);
        }

        public static Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyRandomAsync(flags);
        }

        public static Task<bool> KeyRenameAsync(string key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyRenameAsync(key, newKey, when, flags);
        }

        public static Task KeyRestoreAsync(string key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyRestoreAsync(key, value, expiry, flags);
        }

        public static Task<TimeSpan?> KeyTimeToLiveAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyTimeToLiveAsync(key, flags);
        }

        public static Task<RedisType> KeyTypeAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyTypeAsync(key, flags);
        }

        public static Task<RedisValue> ListGetByIndexAsync(string key, long index, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListGetByIndexAsync(key, index, flags);
        }

        public static Task<long> ListInsertAfterAsync(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListInsertAfterAsync(key, pivot, value, flags);
        }

        public static Task<long> ListInsertBeforeAsync(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListInsertBeforeAsync(key, pivot, value, flags);
        }

        public static Task<RedisValue> ListLeftPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPopAsync(key, flags);
        }

        public static Task<long> ListLeftPushAsync(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPushAsync(key, value, when, flags);
        }

        public static Task<long> ListLeftPushAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPushAsync(key, values, flags);
        }

        public static Task<long> ListLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLengthAsync(key, flags);
        }

        public static Task<RedisValue[]> ListRangeAsync(string key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRangeAsync(key, start, stop, flags);
        }

        public static Task<long> ListRemoveAsync(string key, string value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRemoveAsync(key, value, count, flags);
        }

        public static Task<RedisValue> ListRightPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPopAsync(key, flags);
        }

        public static Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPopLeftPushAsync(source, destination, flags);
        }

        public static Task<long> ListRightPushAsync(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPushAsync(key, value, when, flags);
        }

        public static Task<long> ListRightPushAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPushAsync(key, values, flags);
        }

        public static Task ListSetByIndexAsync(string key, long index, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListSetByIndexAsync(key, index, value, flags);
        }

        public static Task ListTrimAsync(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListTrimAsync(key, start, stop, flags);
        }

        public static Task<bool> LockExtendAsync(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockExtendAsync(key, value, expiry, flags);
        }

        public static Task<RedisValue> LockQueryAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockQueryAsync(key, flags);
        }

        public static Task<bool> LockReleaseAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockReleaseAsync(key, value, flags);
        }

        public static Task<bool> LockTakeAsync(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockTakeAsync(key, value, expiry, flags);
        }

        public static Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return _redis.PublishAsync(channel, message, flags);
        }

        public static Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            return _redis.ExecuteAsync(command, args);
        }

        public static Task<RedisResult> ExecuteAsync(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ExecuteAsync(command, args, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluateAsync(script, keys, values, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluateAsync(hash, keys, values, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluateAsync(script, parameters, flags);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluateAsync(script, parameters, flags);
        }

        public static Task<bool> SetAddAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetAddAsync(key, value, flags);
        }

        public static Task<long> SetAddAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetAddAsync(key, values, flags);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAsync(operation, first, second, flags);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAsync(operation, keys, flags);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAndStoreAsync(operation, destination, first, second, flags);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAndStoreAsync(operation, destination, keys, flags);
        }

        public static Task<bool> SetContainsAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetContainsAsync(key, value, flags);
        }

        public static Task<long> SetLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetLengthAsync(key, flags);
        }

        public static Task<RedisValue[]> SetMembersAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetMembersAsync(key, flags);
        }

        public static Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetMoveAsync(source, destination, value, flags);
        }

        public static Task<RedisValue> SetPopAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetPopAsync(key, flags);
        }

        public static Task<RedisValue[]> SetPopAsync(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetPopAsync(key, count, flags);
        }

        public static Task<RedisValue> SetRandomMemberAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRandomMemberAsync(key, flags);
        }

        public static Task<RedisValue[]> SetRandomMembersAsync(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRandomMembersAsync(key, count, flags);
        }

        public static Task<bool> SetRemoveAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRemoveAsync(key, value, flags);
        }

        public static Task<long> SetRemoveAsync(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRemoveAsync(key, values, flags);
        }

        public static Task<RedisValue[]> SortAsync(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortAsync(key, skip, take, order, sortType, @by, get, flags);
        }

        public static Task<long> SortAndStoreAsync(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortAndStoreAsync(destination, key, skip, take, order, sortType, @by, get, flags);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, CommandFlags flags)
        {
            return _redis.SortedSetAddAsync(key, member, score, flags);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetAddAsync(key, member, score, when, flags);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return _redis.SortedSetAddAsync(key, values, flags);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetAddAsync(key, values, when, flags);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetCombineAndStoreAsync(operation, destination, first, second, aggregate, flags);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys,
            double[] weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetCombineAndStoreAsync(operation, destination, keys, weights, aggregate, flags);
        }

        public static Task<double> SortedSetDecrementAsync(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetDecrementAsync(key, member, value, flags);
        }

        public static Task<double> SortedSetIncrementAsync(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetIncrementAsync(key, member, value, flags);
        }

        public static Task<long> SortedSetLengthAsync(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetLengthAsync(key, min, max, exclude, flags);
        }

        public static Task<long> SortedSetLengthByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetLengthByValueAsync(key, min, max, exclude, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByRankAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByRankAsync(key, start, stop, order, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByRankWithScoresAsync(key, start, stop, order, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByScoreAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None,
            Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByScoreAsync(key, start, stop, exclude, order, skip, take, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByScoreWithScoresAsync(key, start, stop, exclude, order, skip, take, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByValueAsync(key, min, max, exclude, skip, take, flags);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByValueAsync(key, min, max, exclude, order, skip, take, flags);
        }

        public static Task<long?> SortedSetRankAsync(string key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRankAsync(key, member, order, flags);
        }

        public static Task<bool> SortedSetRemoveAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveAsync(key, member, flags);
        }

        public static Task<long> SortedSetRemoveAsync(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveAsync(key, members, flags);
        }

        public static Task<long> SortedSetRemoveRangeByRankAsync(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByRankAsync(key, start, stop, flags);
        }

        public static Task<long> SortedSetRemoveRangeByScoreAsync(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByScoreAsync(key, start, stop, exclude, flags);
        }

        public static Task<long> SortedSetRemoveRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByValueAsync(key, min, max, exclude, flags);
        }

        public static Task<double?> SortedSetScoreAsync(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetScoreAsync(key, member, flags);
        }

        public static Task<SortedSetEntry?> SortedSetPopAsync(string key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetPopAsync(key, order, flags);
        }

        public static Task<SortedSetEntry[]> SortedSetPopAsync(string key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetPopAsync(key, count, order, flags);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAcknowledgeAsync(key, groupName, messageId, flags);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAcknowledgeAsync(key, groupName, messageIds, flags);
        }

        public static Task<RedisValue> StreamAddAsync(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAddAsync(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<RedisValue> StreamAddAsync(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAddAsync(key, streamPairs, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<StreamEntry[]> StreamClaimAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamClaimAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static Task<RedisValue[]> StreamClaimIdsOnlyAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamClaimIdsOnlyAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static Task<bool> StreamConsumerGroupSetPositionAsync(string key, RedisValue groupName, RedisValue position,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamConsumerGroupSetPositionAsync(key, groupName, position, flags);
        }

        public static Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamConsumerInfoAsync(key, groupName, flags);
        }

        public static Task<bool> StreamCreateConsumerGroupAsync(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamCreateConsumerGroupAsync(key, groupName, position, flags);
        }

        public static Task<long> StreamDeleteAsync(string key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDeleteAsync(key, messageIds, flags);
        }

        public static Task<long> StreamDeleteConsumerAsync(string key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDeleteConsumerAsync(key, groupName, consumerName, flags);
        }

        public static Task<bool> StreamDeleteConsumerGroupAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDeleteConsumerGroupAsync(key, groupName, flags);
        }

        public static Task<StreamGroupInfo[]> StreamGroupInfoAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamGroupInfoAsync(key, flags);
        }

        public static Task<StreamInfo> StreamInfoAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamInfoAsync(key, flags);
        }

        public static Task<long> StreamLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamLengthAsync(key, flags);
        }

        public static Task<StreamPendingInfo> StreamPendingAsync(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamPendingAsync(key, groupName, flags);
        }

        public static Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamPendingMessagesAsync(key, groupName, count, consumerName, minId, maxId, flags);
        }

        public static Task<StreamEntry[]> StreamRangeAsync(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamRangeAsync(key, minId, maxId, count, messageOrder, flags);
        }

        public static Task<StreamEntry[]> StreamReadAsync(string key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadAsync(key, position, count, flags);
        }

        public static Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadAsync(streamPositions, countPerStream, flags);
        }

        public static Task<StreamEntry[]> StreamReadGroupAsync(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadGroupAsync(key, groupName, consumerName, position, count, flags);
        }

        public static Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadGroupAsync(streamPositions, groupName, consumerName, countPerStream, flags);
        }

        public static Task<long> StreamTrimAsync(string key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamTrimAsync(key, maxLength, useApproximateMaxLength, flags);
        }

        public static Task<long> StringAppendAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringAppendAsync(key, value, flags);
        }

        public static Task<long> StringBitCountAsync(string key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitCountAsync(key, start, end, flags);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitOperationAsync(operation, destination, first, second, flags);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitOperationAsync(operation, destination, keys, flags);
        }

        public static Task<long> StringBitPositionAsync(string key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitPositionAsync(key, bit, start, end, flags);
        }

        public static Task<long> StringDecrementAsync(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringDecrementAsync(key, value, flags);
        }

        public static Task<double> StringDecrementAsync(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringDecrementAsync(key, value, flags);
        }

        public static Task<RedisValue> StringGetAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetAsync(key, flags);
        }

        public static Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetAsync(keys, flags);
        }

        public static Task<Lease<byte>> StringGetLeaseAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetLeaseAsync(key, flags);
        }

        public static Task<bool> StringGetBitAsync(string key, long offset, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetBitAsync(key, offset, flags);
        }

        public static Task<RedisValue> StringGetRangeAsync(string key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetRangeAsync(key, start, end, flags);
        }

        public static Task<RedisValue> StringGetSetAsync(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetSetAsync(key, value, flags);
        }

        public static Task<RedisValueWithExpiry> StringGetWithExpiryAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetWithExpiryAsync(key, flags);
        }

        public static Task<long> StringIncrementAsync(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringIncrementAsync(key, value, flags);
        }

        public static Task<double> StringIncrementAsync(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringIncrementAsync(key, value, flags);
        }

        public static Task<long> StringLengthAsync(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringLengthAsync(key, flags);
        }

        public static Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = null, When when = When.Always,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetAsync(key, value, expiry, when, flags);
        }

        public static Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetAsync(values, when, flags);
        }

        public static Task<bool> StringSetBitAsync(string key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetBitAsync(key, offset, bit, flags);
        }

        public static Task<RedisValue> StringSetRangeAsync(string key, long offset, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetRangeAsync(key, offset, value, flags);
        }

        public static IBatch CreateBatch(object asyncState = null)
        {
            return _redis.CreateBatch(asyncState);
        }

        public static ITransaction CreateTransaction(object asyncState = null)
        {
            return _redis.CreateTransaction(asyncState);
        }

        public static void KeyMigrate(string key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            _redis.KeyMigrate(key, toServer, toDatabase, timeoutMilliseconds, migrateOptions, flags);
        }

        public static RedisValue DebugObject(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.DebugObject(key, flags);
        }

        public static bool GeoAdd(string key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAdd(key, longitude, latitude, member, flags);
        }

        public static bool GeoAdd(string key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAdd(key, value, flags);
        }

        public static long GeoAdd(string key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoAdd(key, values, flags);
        }

        public static bool GeoRemove(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRemove(key, member, flags);
        }

        public static double? GeoDistance(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoDistance(key, member1, member2, unit, flags);
        }

        public static string[] GeoHash(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoHash(key, members, flags);
        }

        public static string GeoHash(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoHash(key, member, flags);
        }

        public static GeoPosition?[] GeoPosition(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoPosition(key, members, flags);
        }

        public static GeoPosition? GeoPosition(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoPosition(key, member, flags);
        }

        public static GeoRadiusResult[] GeoRadius(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRadius(key, member, radius, unit, count, order, options, flags);
        }

        public static GeoRadiusResult[] GeoRadius(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            return _redis.GeoRadius(key, longitude, latitude, radius, unit, count, order, options, flags);
        }

        public static long HashDecrement(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDecrement(key, hashField, value, flags);
        }

        public static double HashDecrement(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDecrement(key, hashField, value, flags);
        }

        public static bool HashDelete(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDelete(key, hashField, flags);
        }

        public static long HashDelete(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashDelete(key, hashFields, flags);
        }

        public static bool HashExists(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashExists(key, hashField, flags);
        }

        public static RedisValue HashGet(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGet(key, hashField, flags);
        }

        public static Lease<byte> HashGetLease(string key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetLease(key, hashField, flags);
        }

        public static RedisValue[] HashGet(string key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGet(key, hashFields, flags);
        }

        public static HashEntry[] HashGetAll(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashGetAll(key, flags);
        }

        public static long HashIncrement(string key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashIncrement(key, hashField, value, flags);
        }

        public static double HashIncrement(string key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashIncrement(key, hashField, value, flags);
        }

        public static RedisValue[] HashKeys(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashKeys(key, flags);
        }

        public static long HashLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashLength(key, flags);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return _redis.HashScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static void HashSet(string key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            _redis.HashSet(key, hashFields, flags);
        }

        public static bool HashSet(string key, RedisValue hashField, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashSet(key, hashField, value, when, flags);
        }

        public static RedisValue[] HashValues(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HashValues(key, flags);
        }

        public static bool HyperLogLogAdd(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogAdd(key, value, flags);
        }

        public static bool HyperLogLogAdd(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogAdd(key, values, flags);
        }

        public static long HyperLogLogLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogLength(key, flags);
        }

        public static long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.HyperLogLogLength(keys, flags);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            _redis.HyperLogLogMerge(destination, first, second, flags);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            _redis.HyperLogLogMerge(destination, sourceKeys, flags);
        }

        public static bool KeyDelete(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDelete(key, flags);
        }

        public static long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDelete(keys, flags);
        }

        public static byte[] KeyDump(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyDump(key, flags);
        }

        public static bool KeyExists(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExists(key, flags);
        }

        public static long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExists(keys, flags);
        }

        public static bool KeyExpire(string key, double expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExpire(key, DateTime.Now.AddSeconds(expiry), flags);
        }

        public static bool KeyExpire(string key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExpire(key, expiry, flags);
        }

        public static bool KeyExpire(string key, DateTime? expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyExpire(key, expiry, flags);
        }

        public static TimeSpan? KeyIdleTime(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyIdleTime(key, flags);
        }

        public static bool KeyMove(string key, int database, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyMove(key, database, flags);
        }

        public static bool KeyPersist(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyPersist(key, flags);
        }

        public static string keyRandom(CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyRandom(flags);
        }

        public static bool KeyRename(string key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyRename(key, newKey, when, flags);
        }

        public static void KeyRestore(string key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            _redis.KeyRestore(key, value, expiry, flags);
        }

        public static TimeSpan? KeyTimeToLive(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyTimeToLive(key, flags);
        }

        public static RedisType KeyType(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.KeyType(key, flags);
        }

        public static RedisValue ListGetByIndex(string key, long index, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListGetByIndex(key, index, flags);
        }

        public static long ListInsertAfter(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListInsertAfter(key, pivot, value, flags);
        }

        public static long ListInsertBefore(string key, RedisValue pivot, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListInsertBefore(key, pivot, value, flags);
        }

        public static RedisValue ListLeftPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPop(key, flags);
        }

        public static long ListLeftPush(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPush(key, value, when, flags);
        }

        public static long ListLeftPush(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLeftPush(key, values, flags);
        }

        public static long ListLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListLength(key, flags);
        }

        public static RedisValue[] ListRange(string key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRange(key, start, stop, flags);
        }

        public static long ListRemove(string key, string value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRemove(key, value, count, flags);
        }

        public static RedisValue ListRightPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPop(key, flags);
        }

        public static RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPopLeftPush(source, destination, flags);
        }

        public static long ListRightPush(string key, string value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPush(key, value, when, flags);
        }

        public static long ListRightPush(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ListRightPush(key, values, flags);
        }

        public static void ListSetByIndex(string key, long index, string value, CommandFlags flags = CommandFlags.None)
        {
            _redis.ListSetByIndex(key, index, value, flags);
        }

        public static void ListTrim(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            _redis.ListTrim(key, start, stop, flags);
        }

        public static bool LockExtend(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockExtend(key, value, expiry, flags);
        }

        public static RedisValue LockQuery(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockQuery(key, flags);
        }

        public static bool LockRelease(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockRelease(key, value, flags);
        }

        public static bool LockTake(string key, string value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            return _redis.LockTake(key, value, expiry, flags);
        }

        public static long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            return _redis.Publish(channel, message, flags);
        }

        public static RedisResult Execute(string command, params object[] args)
        {
            return _redis.Execute(command, args);
        }

        public static RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            return _redis.Execute(command, args, flags);
        }

        public static RedisResult ScriptEvaluate(string script, RedisKey[] keys = null, RedisValue[] values = null,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluate(script, keys, values, flags);
        }

        public static RedisResult ScriptEvaluate(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluate(hash, keys, values, flags);
        }

        public static RedisResult ScriptEvaluate(LuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluate(script, parameters, flags);
        }

        public static RedisResult ScriptEvaluate(LoadedLuaScript script, object parameters = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.ScriptEvaluate(script, parameters, flags);
        }

        public static bool SetAdd(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetAdd(key, value, flags);
        }

        public static long SetAdd(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetAdd(key, values, flags);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombine(operation, first, second, flags);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombine(operation, keys, flags);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAndStore(operation, destination, first, second, flags);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetCombineAndStore(operation, destination, keys, flags);
        }

        public static bool SetContains(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetContains(key, value, flags);
        }

        public static long SetLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetLength(key, flags);
        }

        public static RedisValue[] SetMembers(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetMembers(key, flags);
        }

        public static bool SetMove(RedisKey source, RedisKey destination, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetMove(source, destination, value, flags);
        }

        public static RedisValue SetPop(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetPop(key, flags);
        }

        public static RedisValue[] SetPop(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetPop(key, count, flags);
        }

        public static RedisValue SetRandomMember(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRandomMember(key, flags);
        }

        public static RedisValue[] SetRandomMembers(string key, long count, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRandomMembers(key, count, flags);
        }

        public static bool SetRemove(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRemove(key, value, flags);
        }

        public static long SetRemove(string key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetRemove(key, values, flags);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return _redis.SetScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SetScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static RedisValue[] Sort(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.Sort(key, skip, take, order, sortType, @by, get, flags);
        }

        public static long SortAndStore(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortAndStore(destination, key, skip, take, order, sortType, @by, get, flags);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, CommandFlags flags)
        {
            return _redis.SortedSetAdd(key, member, score, flags);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetAdd(key, member, score, when, flags);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return _redis.SortedSetAdd(key, values, flags);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetAdd(key, values, when, flags);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetCombineAndStore(operation, destination, first, second, aggregate, flags);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[] weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetCombineAndStore(operation, destination, keys, weights, aggregate, flags);
        }

        public static double SortedSetDecrement(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetDecrement(key, member, value, flags);
        }

        public static double SortedSetIncrement(string key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetIncrement(key, member, value, flags);
        }

        public static long SortedSetLength(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetLength(key, min, max, exclude, flags);
        }

        public static long SortedSetLengthByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetLengthByValue(key, min, max, exclude, flags);
        }

        public static RedisValue[] SortedSetRangeByRank(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByRank(key, start, stop, order, flags);
        }

        public static SortedSetEntry[] SortedSetRangeByRankWithScores(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByRankWithScores(key, start, stop, order, flags);
        }

        public static RedisValue[] SortedSetRangeByScore(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByScore(key, start, stop, exclude, order, skip, take, flags);
        }

        public static SortedSetEntry[] SortedSetRangeByScoreWithScores(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByScoreWithScores(key, start, stop, exclude, order, skip, take, flags);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByValue(key, min, max, exclude, skip, take, flags);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRangeByValue(key, min, max, exclude, order, skip, take, flags);
        }

        public static long? SortedSetRank(string key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRank(key, member, order, flags);
        }

        public static bool SortedSetRemove(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemove(key, member, flags);
        }

        public static long SortedSetRemove(string key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemove(key, members, flags);
        }

        public static long SortedSetRemoveRangeByRank(string key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByRank(key, start, stop, flags);
        }

        public static long SortedSetRemoveRangeByScore(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByScore(key, start, stop, exclude, flags);
        }

        public static long SortedSetRemoveRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetRemoveRangeByValue(key, min, max, exclude, flags);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return _redis.SortedSetScan(key, pattern, pageSize, flags);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetScan(key, pattern, pageSize, cursor, pageOffset, flags);
        }

        public static double? SortedSetScore(string key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetScore(key, member, flags);
        }

        public static SortedSetEntry? SortedSetPop(string key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetPop(key, order, flags);
        }

        public static SortedSetEntry[] SortedSetPop(string key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.SortedSetPop(key, count, order, flags);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAcknowledge(key, groupName, messageId, flags);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAcknowledge(key, groupName, messageIds, flags);
        }

        public static RedisValue StreamAdd(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAdd(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static RedisValue StreamAdd(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamAdd(key, streamPairs, messageId, maxLength, useApproximateMaxLength, flags);
        }

        public static StreamEntry[] StreamClaim(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamClaim(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static RedisValue[] StreamClaimIdsOnly(string key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamClaimIdsOnly(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds, flags);
        }

        public static bool StreamConsumerGroupSetPosition(string key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamConsumerGroupSetPosition(key, groupName, position, flags);
        }

        public static StreamConsumerInfo[] StreamConsumerInfo(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamConsumerInfo(key, groupName, flags);
        }

        public static bool StreamCreateConsumerGroup(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamCreateConsumerGroup(key, groupName, position, flags);
        }

        public static long StreamDelete(string key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDelete(key, messageIds, flags);
        }

        public static long StreamDeleteConsumer(string key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDeleteConsumer(key, groupName, consumerName, flags);
        }

        public static bool StreamDeleteConsumerGroup(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamDeleteConsumerGroup(key, groupName, flags);
        }

        public static StreamGroupInfo[] StreamGroupInfo(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamGroupInfo(key, flags);
        }

        public static StreamInfo StreamInfo(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamInfo(key, flags);
        }

        public static long StreamLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamLength(key, flags);
        }

        public static StreamPendingInfo StreamPending(string key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamPending(key, groupName, flags);
        }

        public static StreamPendingMessageInfo[] StreamPendingMessages(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamPendingMessages(key, groupName, count, consumerName, minId, maxId, flags);
        }

        public static StreamEntry[] StreamRange(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamRange(key, minId, maxId, count, messageOrder, flags);
        }

        public static StreamEntry[] StreamRead(string key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamRead(key, position, count, flags);
        }

        public static RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamRead(streamPositions, countPerStream, flags);
        }

        public static StreamEntry[] StreamReadGroup(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadGroup(key, groupName, consumerName, position, count, flags);
        }

        public static RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamReadGroup(streamPositions, groupName, consumerName, countPerStream, flags);
        }

        public static long StreamTrim(string key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StreamTrim(key, maxLength, useApproximateMaxLength, flags);
        }

        public static long StringAppend(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringAppend(key, value, flags);
        }

        public static long StringBitCount(string key, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitCount(key, start, end, flags);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitOperation(operation, destination, first, second, flags);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitOperation(operation, destination, keys, flags);
        }

        public static long StringBitPosition(string key, bool bit, long start = 0, long end = -1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringBitPosition(key, bit, start, end, flags);
        }

        public static long StringDecrement(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringDecrement(key, value, flags);
        }

        public static double StringDecrement(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringDecrement(key, value, flags);
        }

        public static RedisValue StringGet(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGet(key, flags);
        }

        public static RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGet(keys, flags);
        }

        public static Lease<byte> StringGetLease(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetLease(key, flags);
        }

        public static bool StringGetBit(string key, long offset, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetBit(key, offset, flags);
        }

        public static RedisValue StringGetRange(string key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetRange(key, start, end, flags);
        }

        public static RedisValue StringGetSet(string key, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetSet(key, value, flags);
        }

        public static RedisValueWithExpiry StringGetWithExpiry(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringGetWithExpiry(key, flags);
        }

        public static long StringIncrement(string key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringIncrement(key, value, flags);
        }

        public static double StringIncrement(string key, double value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringIncrement(key, value, flags);
        }

        public static long StringLength(string key, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringLength(key, flags);
        }
        public static bool StringSet(string key, string value, TimeSpan? expiry = null, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSet(key, value, expiry, when, flags);
        }

        public static bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSet(values, when, flags);
        }

        public static bool StringSetBit(string key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetBit(key, offset, bit, flags);
        }

        public static RedisValue StringSetRange(string key, long offset, string value, CommandFlags flags = CommandFlags.None)
        {
            return _redis.StringSetRange(key, offset, value, flags);
        }

        #region 

        public static string[] Scanner(string key)
        {
            var per = LuaScript.Prepare("local res = redis.call('keys',@key); return res;");
            var keys = (string[])_redis.ScriptEvaluate(per, new { key = key });
            return keys;
        }



        #endregion
    }
}