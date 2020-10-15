using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace filter_value.datasource.redis
{
    class Redis
    {


        public static Task<RedisValue> DebugObjectAsync(string key)
        {
            return RedisHelper.DebugObjectAsync(key);
        }

        public static Task<bool> GeoAddAsync(string key, double longitude, double latitude, RedisValue member)
        {
            return RedisHelper.GeoAddAsync(key, longitude, latitude, member);
        }

        public static Task<bool> GeoAddAsync(string key, GeoEntry value)
        {
            return RedisHelper.GeoAddAsync(key, value);
        }

        public static Task<long> GeoAddAsync(string key, GeoEntry[] values)
        {
            return RedisHelper.GeoAddAsync(key, values);
        }

        public static Task<bool> GeoRemoveAsync(string key, RedisValue member)
        {
            return RedisHelper.GeoRemoveAsync(key, member);
        }

        public static Task<double?> GeoDistanceAsync(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.GeoDistanceAsync(key, member1, member2, unit);
        }

        public static Task<string[]> GeoHashAsync(string key, RedisValue[] members)
        {
            return RedisHelper.GeoHashAsync(key, members);
        }

        public static Task<string> GeoHashAsync(string key, RedisValue member)
        {
            return RedisHelper.GeoHashAsync(key, member);
        }

        public static Task<GeoPosition?[]> GeoPositionAsync(string key, RedisValue[] members)
        {
            return RedisHelper.GeoPositionAsync(key, members);
        }

        public static Task<GeoPosition?> GeoPositionAsync(string key, RedisValue member)
        {
            return RedisHelper.GeoPositionAsync(key, member);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default)
        {
            return RedisHelper.GeoRadiusAsync(key, member, radius, unit, count, order, options);
        }

        public static Task<GeoRadiusResult[]> GeoRadiusAsync(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default)
        {
            return RedisHelper.GeoRadiusAsync(key, longitude, latitude, radius, unit, count, order, options);
        }

        public static Task<long> HashDecrementAsync(string key, RedisValue hashField, long value = 1)
        {
            return RedisHelper.HashDecrementAsync(key, hashField, value);
        }

        public static Task<double> HashDecrementAsync(string key, RedisValue hashField, double value)
        {
            return RedisHelper.HashDecrementAsync(key, hashField, value);
        }

        public static Task<bool> HashDeleteAsync(string key, RedisValue hashField)
        {
            return RedisHelper.HashDeleteAsync(key, hashField);
        }

        public static Task<long> HashDeleteAsync(string key, RedisValue[] hashFields)
        {
            return RedisHelper.HashDeleteAsync(key, hashFields);
        }

        public static Task<bool> HashExistsAsync(string key, RedisValue hashField)
        {
            return RedisHelper.HashExistsAsync(key, hashField);
        }

        public static Task<RedisValue> HashGetAsync(string key, RedisValue hashField)
        {
            return RedisHelper.HashGetAsync(key, hashField);
        }

        public static Task<Lease<byte>> HashGetLeaseAsync(string key, RedisValue hashField)
        {
            return RedisHelper.HashGetLeaseAsync(key, hashField);
        }

        public static Task<RedisValue[]> HashGetAsync(string key, RedisValue[] hashFields)
        {
            return RedisHelper.HashGetAsync(key, hashFields);
        }

        public static Task<HashEntry[]> HashGetAllAsync(string key)
        {
            return RedisHelper.HashGetAllAsync(key);
        }

        public static Task<long> HashIncrementAsync(string key, RedisValue hashField, long value = 1)
        {
            return RedisHelper.HashIncrementAsync(key, hashField, value);
        }

        public static Task<double> HashIncrementAsync(string key, RedisValue hashField, double value)
        {
            return RedisHelper.HashIncrementAsync(key, hashField, value);
        }

        public static Task<RedisValue[]> HashKeysAsync(string key)
        {
            return RedisHelper.HashKeysAsync(key);
        }

        public static Task<long> HashLengthAsync(string key)
        {
            return RedisHelper.HashLengthAsync(key);
        }

        public static Task HashSetAsync(string key, HashEntry[] hashFields)
        {
            return RedisHelper.HashSetAsync(key, hashFields);
        }

        public static Task<bool> HashSetAsync(string key, RedisValue hashField, string value, When when = When.Always)
        {
            return RedisHelper.HashSetAsync(key, hashField, value, when);
        }

        public static Task<RedisValue[]> HashValuesAsync(string key)
        {
            return RedisHelper.HashValuesAsync(key);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, string value)
        {
            return RedisHelper.HyperLogLogAddAsync(key, value);
        }

        public static Task<bool> HyperLogLogAddAsync(string key, RedisValue[] values)
        {
            return RedisHelper.HyperLogLogAddAsync(key, values);
        }

        public static Task<long> HyperLogLogLengthAsync(string key)
        {
            return RedisHelper.HyperLogLogLengthAsync(key);
        }

        public static Task<long> HyperLogLogLengthAsync(RedisKey[] keys)
        {
            return RedisHelper.HyperLogLogLengthAsync(keys);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second)
        {
            return RedisHelper.HyperLogLogMergeAsync(destination, first, second);
        }

        public static Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys)
        {
            return RedisHelper.HyperLogLogMergeAsync(destination, sourceKeys);
        }


        public static Task<bool> KeyDeleteAsync(string key)
        {
            return RedisHelper.KeyDeleteAsync(key);
        }

        public static Task<long> KeyDeleteAsync(RedisKey[] keys)
        {
            return RedisHelper.KeyDeleteAsync(keys);
        }

        public static Task<byte[]> KeyDumpAsync(string key)
        {
            return RedisHelper.KeyDumpAsync(key);
        }

        public static Task<bool> KeyExistsAsync(string key)
        {
            return RedisHelper.KeyExistsAsync(key);
        }

        public static Task<long> KeyExistsAsync(RedisKey[] keys)
        {
            return RedisHelper.KeyExistsAsync(keys);
        }

        public static Task<bool> KeyExpireAsync(string key, TimeSpan? expiry)
        {
            return RedisHelper.KeyExpireAsync(key, expiry);
        }

        public static Task<bool> KeyExpireAsync(string key, DateTime? expiry)
        {
            return RedisHelper.KeyExpireAsync(key, expiry);
        }

        public static Task<TimeSpan?> KeyIdleTimeAsync(string key)
        {
            return RedisHelper.KeyIdleTimeAsync(key);
        }

        public static Task<bool> KeyMoveAsync(string key, int database)
        {
            return RedisHelper.KeyMoveAsync(key, database);
        }

        public static Task<bool> KeyPersistAsync(string key)
        {
            return RedisHelper.KeyPersistAsync(key);
        }

        public static Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.KeyRandomAsync(flags);
        }

        public static Task<bool> KeyRenameAsync(string key, RedisKey newKey, When when = When.Always)
        {
            return RedisHelper.KeyRenameAsync(key, newKey, when);
        }

        public static Task KeyRestoreAsync(string key, byte[] value, TimeSpan? expiry = null)
        {
            return RedisHelper.KeyRestoreAsync(key, value, expiry);
        }

        public static Task<TimeSpan?> KeyTimeToLiveAsync(string key)
        {
            return RedisHelper.KeyTimeToLiveAsync(key);
        }

        public static Task<RedisType> KeyTypeAsync(string key)
        {
            return RedisHelper.KeyTypeAsync(key);
        }

        public static Task<RedisValue> ListGetByIndexAsync(string key, long index)
        {
            return RedisHelper.ListGetByIndexAsync(key, index);
        }

        public static Task<long> ListInsertAfterAsync(string key, RedisValue pivot, string value)
        {
            return RedisHelper.ListInsertAfterAsync(key, pivot, value);
        }

        public static Task<long> ListInsertBeforeAsync(string key, RedisValue pivot, string value)
        {
            return RedisHelper.ListInsertBeforeAsync(key, pivot, value);
        }

        public static Task<RedisValue> ListLeftPopAsync(string key)
        {
            return RedisHelper.ListLeftPopAsync(key);
        }

        public static Task<long> ListLeftPushAsync(string key, string value, When when = When.Always)
        {
            return RedisHelper.ListLeftPushAsync(key, value, when);
        }

        public static Task<long> ListLeftPushAsync(string key, RedisValue[] values)
        {
            return RedisHelper.ListLeftPushAsync(key, values);
        }

        public static Task<long> ListLengthAsync(string key)
        {
            return RedisHelper.ListLengthAsync(key);
        }

        public static Task<RedisValue[]> ListRangeAsync(string key, long start = 0, long stop = -1)
        {
            return RedisHelper.ListRangeAsync(key, start, stop);
        }

        public static Task<long> ListRemoveAsync(string key, string value, long count = 0)
        {
            return RedisHelper.ListRemoveAsync(key, value, count);
        }

        public static Task<RedisValue> ListRightPopAsync(string key)
        {
            return RedisHelper.ListRightPopAsync(key);
        }

        public static Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination)
        {
            return RedisHelper.ListRightPopLeftPushAsync(source, destination);
        }

        public static Task<long> ListRightPushAsync(string key, string value, When when = When.Always)
        {
            return RedisHelper.ListRightPushAsync(key, value, when);
        }

        public static Task<long> ListRightPushAsync(string key, RedisValue[] values)
        {
            return RedisHelper.ListRightPushAsync(key, values);
        }

        public static Task ListSetByIndexAsync(string key, long index, string value)
        {
            return RedisHelper.ListSetByIndexAsync(key, index, value);
        }

        public static Task ListTrimAsync(string key, long start, long stop)
        {
            return RedisHelper.ListTrimAsync(key, start, stop);
        }

        public static Task<bool> LockExtendAsync(string key, string value, TimeSpan expiry)
        {
            return RedisHelper.LockExtendAsync(key, value, expiry);
        }

        public static Task<RedisValue> LockQueryAsync(string key)
        {
            return RedisHelper.LockQueryAsync(key);
        }

        public static Task<bool> LockReleaseAsync(string key, string value)
        {
            return RedisHelper.LockReleaseAsync(key, value);
        }

        public static Task<bool> LockTakeAsync(string key, string value, TimeSpan expiry)
        {
            return RedisHelper.LockTakeAsync(key, value, expiry);
        }

        public static Task<long> PublishAsync(RedisChannel channel, RedisValue message)
        {
            return RedisHelper.PublishAsync(channel, message);
        }

        public static Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            return RedisHelper.ExecuteAsync(command, args);
        }

        public static Task<RedisResult> ExecuteAsync(string command, ICollection<object> args)
        {
            return RedisHelper.ExecuteAsync(command, args);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[] keys = null, RedisValue[] values = null)
        {
            return RedisHelper.ScriptEvaluateAsync(script, keys, values);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null)
        {
            return RedisHelper.ScriptEvaluateAsync(hash, keys, values);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object parameters = null)
        {
            return RedisHelper.ScriptEvaluateAsync(script, parameters);
        }

        public static Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object parameters = null)
        {
            return RedisHelper.ScriptEvaluateAsync(script, parameters);
        }

        public static Task<bool> SetAddAsync(string key, string value)
        {
            return RedisHelper.SetAddAsync(key, value);
        }

        public static Task<long> SetAddAsync(string key, RedisValue[] values)
        {
            return RedisHelper.SetAddAsync(key, values);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second)
        {
            return RedisHelper.SetCombineAsync(operation, first, second);
        }

        public static Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys)
        {
            return RedisHelper.SetCombineAsync(operation, keys);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SetCombineAndStoreAsync(operation, destination, first, second);
        }

        public static Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys)
        {
            return RedisHelper.SetCombineAndStoreAsync(operation, destination, keys);
        }

        public static Task<bool> SetContainsAsync(string key, string value)
        {
            return RedisHelper.SetContainsAsync(key, value);
        }

        public static Task<long> SetLengthAsync(string key)
        {
            return RedisHelper.SetLengthAsync(key);
        }

        public static Task<RedisValue[]> SetMembersAsync(string key)
        {
            return RedisHelper.SetMembersAsync(key);
        }

        public static Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, string value)
        {
            return RedisHelper.SetMoveAsync(source, destination, value);
        }

        public static Task<RedisValue> SetPopAsync(string key)
        {
            return RedisHelper.SetPopAsync(key);
        }

        public static Task<RedisValue[]> SetPopAsync(string key, long count)
        {
            return RedisHelper.SetPopAsync(key, count);
        }

        public static Task<RedisValue> SetRandomMemberAsync(string key)
        {
            return RedisHelper.SetRandomMemberAsync(key);
        }

        public static Task<RedisValue[]> SetRandomMembersAsync(string key, long count)
        {
            return RedisHelper.SetRandomMembersAsync(key, count);
        }

        public static Task<bool> SetRemoveAsync(string key, string value)
        {
            return RedisHelper.SetRemoveAsync(key, value);
        }

        public static Task<long> SetRemoveAsync(string key, RedisValue[] values)
        {
            return RedisHelper.SetRemoveAsync(key, values);
        }

        public static Task<RedisValue[]> SortAsync(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue @by = new RedisValue(), RedisValue[] get = null)
        {
            return RedisHelper.SortAsync(key, skip, take, order, sortType, @by, get);
        }

        public static Task<long> SortAndStoreAsync(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null)
        {
            return RedisHelper.SortAndStoreAsync(destination, key, skip, take, order, sortType, @by, get);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, CommandFlags flags)
        {
            return RedisHelper.SortedSetAddAsync(key, member, score);
        }

        public static Task<bool> SortedSetAddAsync(string key, RedisValue member, double score, When when = When.Always)
        {
            return RedisHelper.SortedSetAddAsync(key, member, score, when);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return RedisHelper.SortedSetAddAsync(key, values);
        }

        public static Task<long> SortedSetAddAsync(string key, SortedSetEntry[] values, When when = When.Always)
        {
            return RedisHelper.SortedSetAddAsync(key, values, when);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum)
        {
            return RedisHelper.SortedSetCombineAndStoreAsync(operation, destination, first, second, aggregate);
        }

        public static Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys,
            double[] weights = null, Aggregate aggregate = Aggregate.Sum)
        {
            return RedisHelper.SortedSetCombineAndStoreAsync(operation, destination, keys, weights, aggregate);
        }

        public static Task<double> SortedSetDecrementAsync(string key, RedisValue member, double value)
        {
            return RedisHelper.SortedSetDecrementAsync(key, member, value);
        }

        public static Task<double> SortedSetIncrementAsync(string key, RedisValue member, double value)
        {
            return RedisHelper.SortedSetIncrementAsync(key, member, value);
        }

        public static Task<long> SortedSetLengthAsync(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetLengthAsync(key, min, max, exclude);
        }

        public static Task<long> SortedSetLengthByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetLengthByValueAsync(key, min, max, exclude);
        }

        public static Task<RedisValue[]> SortedSetRangeByRankAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRangeByRankAsync(key, start, stop, order);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(string key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRangeByRankWithScoresAsync(key, start, stop, order);
        }

        public static Task<RedisValue[]> SortedSetRangeByScoreAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None,
            Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByScoreAsync(key, start, stop, exclude, order, skip, take);
        }

        public static Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByScoreWithScoresAsync(key, start, stop, exclude, order, skip, take);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1)
        {
            return RedisHelper.SortedSetRangeByValueAsync(key, min, max, exclude, skip, take);
        }

        public static Task<RedisValue[]> SortedSetRangeByValueAsync(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByValueAsync(key, min, max, exclude, order, skip, take);
        }

        public static Task<long?> SortedSetRankAsync(string key, RedisValue member, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetRankAsync(key, member, order);
        }

        public static Task<bool> SortedSetRemoveAsync(string key, RedisValue member)
        {
            return RedisHelper.SortedSetRemoveAsync(key, member);
        }

        public static Task<long> SortedSetRemoveAsync(string key, RedisValue[] members)
        {
            return RedisHelper.SortedSetRemoveAsync(key, members);
        }

        public static Task<long> SortedSetRemoveRangeByRankAsync(string key, long start, long stop)
        {
            return RedisHelper.SortedSetRemoveRangeByRankAsync(key, start, stop);
        }

        public static Task<long> SortedSetRemoveRangeByScoreAsync(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRemoveRangeByScoreAsync(key, start, stop, exclude);
        }

        public static Task<long> SortedSetRemoveRangeByValueAsync(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRemoveRangeByValueAsync(key, min, max, exclude);
        }

        public static Task<double?> SortedSetScoreAsync(string key, RedisValue member)
        {
            return RedisHelper.SortedSetScoreAsync(key, member);
        }

        public static Task<SortedSetEntry?> SortedSetPopAsync(string key, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetPopAsync(key, order);
        }

        public static Task<SortedSetEntry[]> SortedSetPopAsync(string key, long count, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetPopAsync(key, count, order);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue messageId)
        {
            return RedisHelper.StreamAcknowledgeAsync(key, groupName, messageId);
        }

        public static Task<long> StreamAcknowledgeAsync(string key, RedisValue groupName, RedisValue[] messageIds)
        {
            return RedisHelper.StreamAcknowledgeAsync(key, groupName, messageIds);
        }

        public static Task<RedisValue> StreamAddAsync(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamAddAsync(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength);
        }

        public static Task<RedisValue> StreamAddAsync(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamAddAsync(key, streamPairs, messageId, maxLength, useApproximateMaxLength);
        }

        public static Task<StreamEntry[]> StreamClaimAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds)
        {
            return RedisHelper.StreamClaimAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds);
        }

        public static Task<RedisValue[]> StreamClaimIdsOnlyAsync(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds)
        {
            return RedisHelper.StreamClaimIdsOnlyAsync(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds);
        }

        public static Task<bool> StreamConsumerGroupSetPositionAsync(string key, RedisValue groupName, RedisValue position,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StreamConsumerGroupSetPositionAsync(key, groupName, position);
        }

        public static Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(string key, RedisValue groupName)
        {
            return RedisHelper.StreamConsumerInfoAsync(key, groupName);
        }

        public static Task<bool> StreamCreateConsumerGroupAsync(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StreamCreateConsumerGroupAsync(key, groupName, position);
        }

        public static Task<long> StreamDeleteAsync(string key, RedisValue[] messageIds)
        {
            return RedisHelper.StreamDeleteAsync(key, messageIds);
        }

        public static Task<long> StreamDeleteConsumerAsync(string key, RedisValue groupName, RedisValue consumerName)
        {
            return RedisHelper.StreamDeleteConsumerAsync(key, groupName, consumerName);
        }

        public static Task<bool> StreamDeleteConsumerGroupAsync(string key, RedisValue groupName)
        {
            return RedisHelper.StreamDeleteConsumerGroupAsync(key, groupName);
        }

        public static Task<StreamGroupInfo[]> StreamGroupInfoAsync(string key)
        {
            return RedisHelper.StreamGroupInfoAsync(key);
        }

        public static Task<StreamInfo> StreamInfoAsync(string key)
        {
            return RedisHelper.StreamInfoAsync(key);
        }

        public static Task<long> StreamLengthAsync(string key)
        {
            return RedisHelper.StreamLengthAsync(key);
        }

        public static Task<StreamPendingInfo> StreamPendingAsync(string key, RedisValue groupName)
        {
            return RedisHelper.StreamPendingAsync(key, groupName);
        }

        public static Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null)
        {
            return RedisHelper.StreamPendingMessagesAsync(key, groupName, count, consumerName, minId, maxId);
        }

        public static Task<StreamEntry[]> StreamRangeAsync(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending)
        {
            return RedisHelper.StreamRangeAsync(key, minId, maxId, count, messageOrder);
        }

        public static Task<StreamEntry[]> StreamReadAsync(string key, RedisValue position, int? count = null)
        {
            return RedisHelper.StreamReadAsync(key, position, count);
        }

        public static Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null)
        {
            return RedisHelper.StreamReadAsync(streamPositions, countPerStream);
        }

        public static Task<StreamEntry[]> StreamReadGroupAsync(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null)
        {
            return RedisHelper.StreamReadGroupAsync(key, groupName, consumerName, position, count);
        }

        public static Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null)
        {
            return RedisHelper.StreamReadGroupAsync(streamPositions, groupName, consumerName, countPerStream);
        }

        public static Task<long> StreamTrimAsync(string key, int maxLength, bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamTrimAsync(key, maxLength, useApproximateMaxLength);
        }

        public static Task<long> StringAppendAsync(string key, string value)
        {
            return RedisHelper.StringAppendAsync(key, value);
        }

        public static Task<long> StringBitCountAsync(string key, long start = 0, long end = -1)
        {
            return RedisHelper.StringBitCountAsync(key, start, end);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StringBitOperationAsync(operation, destination, first, second);
        }

        public static Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys)
        {
            return RedisHelper.StringBitOperationAsync(operation, destination, keys);
        }

        public static Task<long> StringBitPositionAsync(string key, bool bit, long start = 0, long end = -1)
        {
            return RedisHelper.StringBitPositionAsync(key, bit, start, end);
        }

        public static Task<long> StringDecrementAsync(string key, long value = 1)
        {
            return RedisHelper.StringDecrementAsync(key, value);
        }

        public static Task<double> StringDecrementAsync(string key, double value)
        {
            return RedisHelper.StringDecrementAsync(key, value);
        }

        public static Task<RedisValue> StringGetAsync(string key)
        {
            return RedisHelper.StringGetAsync(key);
        }

        public static Task<RedisValue[]> StringGetAsync(RedisKey[] keys)
        {
            return RedisHelper.StringGetAsync(keys);
        }

        public static Task<Lease<byte>> StringGetLeaseAsync(string key)
        {
            return RedisHelper.StringGetLeaseAsync(key);
        }

        public static Task<bool> StringGetBitAsync(string key, long offset)
        {
            return RedisHelper.StringGetBitAsync(key, offset);
        }

        public static Task<RedisValue> StringGetRangeAsync(string key, long start, long end)
        {
            return RedisHelper.StringGetRangeAsync(key, start, end);
        }

        public static Task<RedisValue> StringGetSetAsync(string key, string value)
        {
            return RedisHelper.StringGetSetAsync(key, value);
        }

        public static Task<RedisValueWithExpiry> StringGetWithExpiryAsync(string key)
        {
            return RedisHelper.StringGetWithExpiryAsync(key);
        }

        public static Task<long> StringIncrementAsync(string key, long value = 1)
        {
            return RedisHelper.StringIncrementAsync(key, value);
        }

        public static Task<double> StringIncrementAsync(string key, double value)
        {
            return RedisHelper.StringIncrementAsync(key, value);
        }

        public static Task<long> StringLengthAsync(string key)
        {
            return RedisHelper.StringLengthAsync(key);
        }

        public static Task<bool> StringSetAsync(string key, string value,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StringSetAsync(key, value);
        }

        public static Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always)
        {
            return RedisHelper.StringSetAsync(values, when);
        }

        public static Task<bool> StringSetBitAsync(string key, long offset, bool bit)
        {
            return RedisHelper.StringSetBitAsync(key, offset, bit);
        }

        public static Task<RedisValue> StringSetRangeAsync(string key, long offset, string value)
        {
            return RedisHelper.StringSetRangeAsync(key, offset, value);
        }

        public static IBatch CreateBatch(object asyncState = null)
        {
            return RedisHelper.CreateBatch(asyncState);
        }

        public static ITransaction CreateTransaction(object asyncState = null)
        {
            return RedisHelper.CreateTransaction(asyncState);
        }

        public static void KeyMigrate(string key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None)
        {
            RedisHelper.KeyMigrate(key, toServer, toDatabase, timeoutMilliseconds, migrateOptions);
        }

        public static RedisValue DebugObject(string key)
        {
            return RedisHelper.DebugObject(key);
        }

        public static bool GeoAdd(string key, double longitude, double latitude, RedisValue member)
        {
            return RedisHelper.GeoAdd(key, longitude, latitude, member);
        }

        public static bool GeoAdd(string key, GeoEntry value)
        {
            return RedisHelper.GeoAdd(key, value);
        }

        public static long GeoAdd(string key, GeoEntry[] values)
        {
            return RedisHelper.GeoAdd(key, values);
        }

        public static bool GeoRemove(string key, RedisValue member)
        {
            return RedisHelper.GeoRemove(key, member);
        }

        public static double? GeoDistance(string key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.GeoDistance(key, member1, member2, unit);
        }

        public static string[] GeoHash(string key, RedisValue[] members)
        {
            return RedisHelper.GeoHash(key, members);
        }

        public static string GeoHash(string key, RedisValue member)
        {
            return RedisHelper.GeoHash(key, member);
        }

        public static GeoPosition?[] GeoPosition(string key, RedisValue[] members)
        {
            return RedisHelper.GeoPosition(key, members);
        }

        public static GeoPosition? GeoPosition(string key, RedisValue member)
        {
            return RedisHelper.GeoPosition(key, member);
        }

        public static GeoRadiusResult[] GeoRadius(string key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default)
        {
            return RedisHelper.GeoRadius(key, member, radius, unit, count, order, options);
        }

        public static GeoRadiusResult[] GeoRadius(string key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default)
        {
            return RedisHelper.GeoRadius(key, longitude, latitude, radius, unit, count, order, options);
        }

        public static long HashDecrement(string key, RedisValue hashField, long value = 1)
        {
            return RedisHelper.HashDecrement(key, hashField, value);
        }

        public static double HashDecrement(string key, RedisValue hashField, double value)
        {
            return RedisHelper.HashDecrement(key, hashField, value);
        }

        public static bool HashDelete(string key, RedisValue hashField)
        {
            return RedisHelper.HashDelete(key, hashField);
        }

        public static long HashDelete(string key, RedisValue[] hashFields)
        {
            return RedisHelper.HashDelete(key, hashFields);
        }

        public static bool HashExists(string key, RedisValue hashField)
        {
            return RedisHelper.HashExists(key, hashField);
        }

        public static RedisValue HashGet(string key, RedisValue hashField)
        {
            return RedisHelper.HashGet(key, hashField);
        }

        public static Lease<byte> HashGetLease(string key, RedisValue hashField)
        {
            return RedisHelper.HashGetLease(key, hashField);
        }

        public static RedisValue[] HashGet(string key, RedisValue[] hashFields)
        {
            return RedisHelper.HashGet(key, hashFields);
        }

        public static HashEntry[] HashGetAll(string key)
        {
            return RedisHelper.HashGetAll(key);
        }

        public static long HashIncrement(string key, RedisValue hashField, long value = 1)
        {
            return RedisHelper.HashIncrement(key, hashField, value);
        }

        public static double HashIncrement(string key, RedisValue hashField, double value)
        {
            return RedisHelper.HashIncrement(key, hashField, value);
        }

        public static RedisValue[] HashKeys(string key)
        {
            return RedisHelper.HashKeys(key);
        }

        public static long HashLength(string key)
        {
            return RedisHelper.HashLength(key);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return RedisHelper.HashScan(key, pattern, pageSize);
        }

        public static IEnumerable<HashEntry> HashScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0)
        {
            return RedisHelper.HashScan(key, pattern, pageSize, cursor, pageOffset);
        }

        public static void HashSet(string key, HashEntry[] hashFields)
        {
            RedisHelper.HashSet(key, hashFields);
        }

        public static bool HashSet(string key, RedisValue hashField, string value, When when = When.Always)
        {
            return RedisHelper.HashSet(key, hashField, value, when);
        }

        public static RedisValue[] HashValues(string key)
        {
            return RedisHelper.HashValues(key);
        }

        public static bool HyperLogLogAdd(string key, string value)
        {
            return RedisHelper.HyperLogLogAdd(key, value);
        }

        public static bool HyperLogLogAdd(string key, RedisValue[] values)
        {
            return RedisHelper.HyperLogLogAdd(key, values);
        }

        public static long HyperLogLogLength(string key)
        {
            return RedisHelper.HyperLogLogLength(key);
        }

        public static long HyperLogLogLength(RedisKey[] keys)
        {
            return RedisHelper.HyperLogLogLength(keys);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second)
        {
            RedisHelper.HyperLogLogMerge(destination, first, second);
        }

        public static void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys)
        {
            RedisHelper.HyperLogLogMerge(destination, sourceKeys);
        }

        public static bool KeyDelete(string key)
        {
            return RedisHelper.KeyDelete(key);
        }

        public static long KeyDelete(RedisKey[] keys)
        {
            return RedisHelper.KeyDelete(keys);
        }

        public static byte[] KeyDump(string key)
        {
            return RedisHelper.KeyDump(key);
        }

        public static bool KeyExists(string key)
        {
            return RedisHelper.KeyExists(key);
        }

        public static long KeyExists(RedisKey[] keys)
        {
            return RedisHelper.KeyExists(keys);
        }

        public static bool KeyExpire(string key, double expiry)
        {
            return RedisHelper.KeyExpire(key, DateTime.Now.AddSeconds(expiry));
        }

        public static bool KeyExpire(string key, TimeSpan? expiry)
        {
            return RedisHelper.KeyExpire(key, expiry);
        }

        public static bool KeyExpire(string key, DateTime? expiry)
        {
            return RedisHelper.KeyExpire(key, expiry);
        }

        public static TimeSpan? KeyIdleTime(string key)
        {
            return RedisHelper.KeyIdleTime(key);
        }

        public static bool KeyMove(string key, int database)
        {
            return RedisHelper.KeyMove(key, database);
        }

        public static bool KeyPersist(string key)
        {
            return RedisHelper.KeyPersist(key);
        }

        public static bool KeyRename(string key, RedisKey newKey, When when = When.Always)
        {
            return RedisHelper.KeyRename(key, newKey, when);
        }

        public static void KeyRestore(string key, byte[] value, TimeSpan? expiry = null)
        {
            RedisHelper.KeyRestore(key, value, expiry);
        }

        public static TimeSpan? KeyTimeToLive(string key)
        {
            return RedisHelper.KeyTimeToLive(key);
        }

        public static string KeyType(string key)
        {
            return RedisHelper.KeyType(key).ToString();
        }

        public static RedisValue ListGetByIndex(string key, long index)
        {
            return RedisHelper.ListGetByIndex(key, index);
        }

        public static long ListInsertAfter(string key, RedisValue pivot, string value)
        {
            return RedisHelper.ListInsertAfter(key, pivot, value);
        }

        public static long ListInsertBefore(string key, RedisValue pivot, string value)
        {
            return RedisHelper.ListInsertBefore(key, pivot, value);
        }

        public static RedisValue ListLeftPop(string key)
        {
            return RedisHelper.ListLeftPop(key);
        }

        public static long ListLeftPush(string key, string value, When when = When.Always)
        {
            return RedisHelper.ListLeftPush(key, value, when);
        }

        public static long ListLeftPush(string key, RedisValue[] values)
        {
            return RedisHelper.ListLeftPush(key, values);
        }

        public static long ListLength(string key)
        {
            return RedisHelper.ListLength(key);
        }

        public static string[] ListRange(string key, long start = 0, long stop = -1)
        {
            var arr = RedisHelper.ListRange(key, start, stop).Select(x => (string)x).ToArray();
            return arr;
        }

        public static long ListRemove(string key, string value, long count = 0)
        {
            return RedisHelper.ListRemove(key, value, count);
        }

        public static RedisValue ListRightPop(string key)
        {
            return RedisHelper.ListRightPop(key);
        }

        public static RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination)
        {
            return RedisHelper.ListRightPopLeftPush(source, destination);
        }

        public static long ListRightPush(string key, string value, When when = When.Always)
        {
            return RedisHelper.ListRightPush(key, value, when);
        }

        public static long ListRightPush(string key, RedisValue[] values)
        {
            return RedisHelper.ListRightPush(key, values);
        }

        public static void ListSetByIndex(string key, long index, string value)
        {
            RedisHelper.ListSetByIndex(key, index, value);
        }

        public static void ListTrim(string key, long start, long stop)
        {
            RedisHelper.ListTrim(key, start, stop);
        }

        public static bool LockExtend(string key, string value, TimeSpan expiry)
        {
            return RedisHelper.LockExtend(key, value, expiry);
        }

        public static RedisValue LockQuery(string key)
        {
            return RedisHelper.LockQuery(key);
        }

        public static bool LockRelease(string key, string value)
        {
            return RedisHelper.LockRelease(key, value);
        }

        public static bool LockTake(string key, string value, TimeSpan expiry)
        {
            return RedisHelper.LockTake(key, value, expiry);
        }

        public static long Publish(RedisChannel channel, RedisValue message)
        {
            return RedisHelper.Publish(channel, message);
        }

        public static RedisResult Execute(string command, params object[] args)
        {
            return RedisHelper.Execute(command, args);
        }

        public static RedisResult Execute(string command, ICollection<object> args)
        {
            return RedisHelper.Execute(command, args);
        }

        public static RedisResult ScriptEvaluate(string script, RedisKey[] keys = null, RedisValue[] values = null,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.ScriptEvaluate(script, keys, values);
        }

        public static RedisResult ScriptEvaluate(byte[] hash, RedisKey[] keys = null, RedisValue[] values = null)
        {
            return RedisHelper.ScriptEvaluate(hash, keys, values);
        }

        public static RedisResult ScriptEvaluate(LuaScript script, object parameters = null)
        {
            return RedisHelper.ScriptEvaluate(script, parameters);
        }

        public static RedisResult ScriptEvaluate(LoadedLuaScript script, object parameters = null)
        {
            return RedisHelper.ScriptEvaluate(script, parameters);
        }

        public static bool SetAdd(string key, string value)
        {
            return RedisHelper.SetAdd(key, value);
        }

        public static long SetAdd(string key, RedisValue[] values)
        {
            return RedisHelper.SetAdd(key, values);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second)
        {
            return RedisHelper.SetCombine(operation, first, second);
        }

        public static RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys)
        {
            return RedisHelper.SetCombine(operation, keys);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SetCombineAndStore(operation, destination, first, second);
        }

        public static long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys)
        {
            return RedisHelper.SetCombineAndStore(operation, destination, keys);
        }

        public static bool SetContains(string key, string value)
        {
            return RedisHelper.SetContains(key, value);
        }

        public static long SetLength(string key)
        {
            return RedisHelper.SetLength(key);
        }

        public static RedisValue[] SetMembers(string key)
        {
            return RedisHelper.SetMembers(key);
        }

        public static bool SetMove(RedisKey source, RedisKey destination, string value)
        {
            return RedisHelper.SetMove(source, destination, value);
        }

        public static RedisValue SetPop(string key)
        {
            return RedisHelper.SetPop(key);
        }

        public static RedisValue[] SetPop(string key, long count)
        {
            return RedisHelper.SetPop(key, count);
        }

        public static RedisValue SetRandomMember(string key)
        {
            return RedisHelper.SetRandomMember(key);
        }

        public static RedisValue[] SetRandomMembers(string key, long count)
        {
            return RedisHelper.SetRandomMembers(key, count);
        }

        public static bool SetRemove(string key, string value)
        {
            return RedisHelper.SetRemove(key, value);
        }

        public static long SetRemove(string key, RedisValue[] values)
        {
            return RedisHelper.SetRemove(key, values);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return RedisHelper.SetScan(key, pattern, pageSize);
        }

        public static IEnumerable<RedisValue> SetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0)
        {
            return RedisHelper.SetScan(key, pattern, pageSize, cursor, pageOffset);
        }

        public static RedisValue[] Sort(string key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue @by = new RedisValue(), RedisValue[] get = null)
        {
            return RedisHelper.Sort(key, skip, take, order, sortType, @by, get);
        }

        public static long SortAndStore(RedisKey destination, string key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue @by = new RedisValue(), RedisValue[] get = null)
        {
            return RedisHelper.SortAndStore(destination, key, skip, take, order, sortType, @by, get);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, CommandFlags flags)
        {
            return RedisHelper.SortedSetAdd(key, member, score);
        }

        public static bool SortedSetAdd(string key, RedisValue member, double score, When when = When.Always)
        {
            return RedisHelper.SortedSetAdd(key, member, score, when);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, CommandFlags flags)
        {
            return RedisHelper.SortedSetAdd(key, values);
        }

        public static long SortedSetAdd(string key, SortedSetEntry[] values, When when = When.Always)
        {
            return RedisHelper.SortedSetAdd(key, values, when);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum)
        {
            return RedisHelper.SortedSetCombineAndStore(operation, destination, first, second, aggregate);
        }

        public static long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[] weights = null,
            Aggregate aggregate = Aggregate.Sum)
        {
            return RedisHelper.SortedSetCombineAndStore(operation, destination, keys, weights, aggregate);
        }

        public static double SortedSetDecrement(string key, RedisValue member, double value)
        {
            return RedisHelper.SortedSetDecrement(key, member, value);
        }

        public static double SortedSetIncrement(string key, RedisValue member, double value)
        {
            return RedisHelper.SortedSetIncrement(key, member, value);
        }

        public static long SortedSetLength(string key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetLength(key, min, max, exclude);
        }

        public static long SortedSetLengthByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetLengthByValue(key, min, max, exclude);
        }

        public static RedisValue[] SortedSetRangeByRank(string key, long start = 0, long stop = -1, Order order = Order.Ascending
           )
        {
            return RedisHelper.SortedSetRangeByRank(key, start, stop, order);
        }

        public static SortedSetEntry[] SortedSetRangeByRankWithScores(string key, long start = 0, long stop = -1, Order order = Order.Ascending
           )
        {
            return RedisHelper.SortedSetRangeByRankWithScores(key, start, stop, order);
        }

        public static RedisValue[] SortedSetRangeByScore(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByScore(key, start, stop, exclude, order, skip, take);
        }

        public static SortedSetEntry[] SortedSetRangeByScoreWithScores(string key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByScoreWithScores(key, start, stop, exclude, order, skip, take);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1)
        {
            return RedisHelper.SortedSetRangeByValue(key, min, max, exclude, skip, take);
        }

        public static RedisValue[] SortedSetRangeByValue(string key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1)
        {
            return RedisHelper.SortedSetRangeByValue(key, min, max, exclude, order, skip, take);
        }

        public static long? SortedSetRank(string key, RedisValue member, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetRank(key, member, order);
        }

        public static bool SortedSetRemove(string key, RedisValue member)
        {
            return RedisHelper.SortedSetRemove(key, member);
        }

        public static long SortedSetRemove(string key, RedisValue[] members)
        {
            return RedisHelper.SortedSetRemove(key, members);
        }

        public static long SortedSetRemoveRangeByRank(string key, long start, long stop)
        {
            return RedisHelper.SortedSetRemoveRangeByRank(key, start, stop);
        }

        public static long SortedSetRemoveRangeByScore(string key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRemoveRangeByScore(key, start, stop, exclude);
        }

        public static long SortedSetRemoveRangeByValue(string key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.SortedSetRemoveRangeByValue(key, min, max, exclude);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            return RedisHelper.SortedSetScan(key, pattern, pageSize);
        }

        public static IEnumerable<SortedSetEntry> SortedSetScan(string key, RedisValue pattern = new RedisValue(), int pageSize = 10, long cursor = 0,
            int pageOffset = 0)
        {
            return RedisHelper.SortedSetScan(key, pattern, pageSize, cursor, pageOffset);
        }

        public static double? SortedSetScore(string key, RedisValue member)
        {
            return RedisHelper.SortedSetScore(key, member);
        }

        public static SortedSetEntry? SortedSetPop(string key, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetPop(key, order);
        }

        public static SortedSetEntry[] SortedSetPop(string key, long count, Order order = Order.Ascending)
        {
            return RedisHelper.SortedSetPop(key, count, order);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue messageId)
        {
            return RedisHelper.StreamAcknowledge(key, groupName, messageId);
        }

        public static long StreamAcknowledge(string key, RedisValue groupName, RedisValue[] messageIds)
        {
            return RedisHelper.StreamAcknowledge(key, groupName, messageIds);
        }

        public static RedisValue StreamAdd(string key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamAdd(key, streamField, streamValue, messageId, maxLength, useApproximateMaxLength);
        }

        public static RedisValue StreamAdd(string key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamAdd(key, streamPairs, messageId, maxLength, useApproximateMaxLength);
        }

        public static StreamEntry[] StreamClaim(string key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds)
        {
            return RedisHelper.StreamClaim(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds);
        }

        public static RedisValue[] StreamClaimIdsOnly(string key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue[] messageIds)
        {
            return RedisHelper.StreamClaimIdsOnly(key, consumerGroup, claimingConsumer, minIdleTimeInMs, messageIds);
        }

        public static bool StreamConsumerGroupSetPosition(string key, RedisValue groupName, RedisValue position)
        {
            return RedisHelper.StreamConsumerGroupSetPosition(key, groupName, position);
        }

        public static StreamConsumerInfo[] StreamConsumerInfo(string key, RedisValue groupName)
        {
            return RedisHelper.StreamConsumerInfo(key, groupName);
        }

        public static bool StreamCreateConsumerGroup(string key, RedisValue groupName, RedisValue? position = null,
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StreamCreateConsumerGroup(key, groupName, position);
        }

        public static long StreamDelete(string key, RedisValue[] messageIds)
        {
            return RedisHelper.StreamDelete(key, messageIds);
        }

        public static long StreamDeleteConsumer(string key, RedisValue groupName, RedisValue consumerName)
        {
            return RedisHelper.StreamDeleteConsumer(key, groupName, consumerName);
        }

        public static bool StreamDeleteConsumerGroup(string key, RedisValue groupName)
        {
            return RedisHelper.StreamDeleteConsumerGroup(key, groupName);
        }

        public static StreamGroupInfo[] StreamGroupInfo(string key)
        {
            return RedisHelper.StreamGroupInfo(key);
        }

        public static StreamInfo StreamInfo(string key)
        {
            return RedisHelper.StreamInfo(key);
        }

        public static long StreamLength(string key)
        {
            return RedisHelper.StreamLength(key);
        }

        public static StreamPendingInfo StreamPending(string key, RedisValue groupName)
        {
            return RedisHelper.StreamPending(key, groupName);
        }

        public static StreamPendingMessageInfo[] StreamPendingMessages(string key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null)
        {
            return RedisHelper.StreamPendingMessages(key, groupName, count, consumerName, minId, maxId);
        }

        public static StreamEntry[] StreamRange(string key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending)
        {
            return RedisHelper.StreamRange(key, minId, maxId, count, messageOrder);
        }

        public static StreamEntry[] StreamRead(string key, RedisValue position, int? count = null)
        {
            return RedisHelper.StreamRead(key, position, count);
        }

        public static RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null)
        {
            return RedisHelper.StreamRead(streamPositions, countPerStream);
        }

        public static StreamEntry[] StreamReadGroup(string key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null)
        {
            return RedisHelper.StreamReadGroup(key, groupName, consumerName, position, count);
        }

        public static RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null)
        {
            return RedisHelper.StreamReadGroup(streamPositions, groupName, consumerName, countPerStream);
        }

        public static long StreamTrim(string key, int maxLength, bool useApproximateMaxLength = false)
        {
            return RedisHelper.StreamTrim(key, maxLength, useApproximateMaxLength);
        }

        public static long StringAppend(string key, string value)
        {
            return RedisHelper.StringAppend(key, value);
        }

        public static long StringBitCount(string key, long start = 0, long end = -1)
        {
            return RedisHelper.StringBitCount(key, start, end);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            return RedisHelper.StringBitOperation(operation, destination, first, second);
        }

        public static long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys)
        {
            return RedisHelper.StringBitOperation(operation, destination, keys);
        }

        public static long StringBitPosition(string key, bool bit, long start = 0, long end = -1)
        {
            return RedisHelper.StringBitPosition(key, bit, start, end);
        }

        public static long StringDecrement(string key, long value = 1)
        {
            return RedisHelper.StringDecrement(key, value);
        }

        public static double StringDecrement(string key, double value)
        {
            return RedisHelper.StringDecrement(key, value);
        }

        public static RedisValue StringGet(string key)
        {
            return RedisHelper.StringGet(key);
        }

        public static RedisValue[] StringGet(RedisKey[] keys)
        {
            return RedisHelper.StringGet(keys);
        }

        public static Lease<byte> StringGetLease(string key)
        {
            return RedisHelper.StringGetLease(key);
        }

        public static bool StringGetBit(string key, long offset)
        {
            return RedisHelper.StringGetBit(key, offset);
        }

        public static RedisValue StringGetRange(string key, long start, long end)
        {
            return RedisHelper.StringGetRange(key, start, end);
        }

        public static RedisValue StringGetSet(string key, string value)
        {
            return RedisHelper.StringGetSet(key, value);
        }

        public static RedisValueWithExpiry StringGetWithExpiry(string key)
        {
            return RedisHelper.StringGetWithExpiry(key);
        }

        public static long StringIncrement(string key, long value = 1)
        {
            return RedisHelper.StringIncrement(key, value);
        }

        public static double StringIncrement(string key, double value)
        {
            return RedisHelper.StringIncrement(key, value);
        }

        public static long StringLength(string key)
        {
            return RedisHelper.StringLength(key);
        }
        public static bool StringSet(string key, string value)
        {
            return RedisHelper.StringSet(key, value);
        }

        public static bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values)
        {
            return RedisHelper.StringSet(values);
        }

        public static bool StringSetBit(string key, long offset, bool bit)
        {
            return RedisHelper.StringSetBit(key, offset, bit);
        }

        public static RedisValue StringSetRange(string key, long offset, string value)
        {
            return RedisHelper.StringSetRange(key, offset, value);
        }
    }
}
