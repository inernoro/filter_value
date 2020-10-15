 --[[

[redis]
--redishost 127.0.0.1
--redispwd =  
--redisdb=0

help
save() 保存到文件

]]

local redislua = {};

local help = clr.filter_value.datasource.help;
local redis = clr.filter_value.datasource.redis.Redis;
local redis_helper = clr.filter_value.datasource.redis.RedisHelper;
 

 function stringGet( key ) 
	local value = redis.StringGet(key);  
	redislua.analysis(value);
	return value;
end


function listGet( key )
	local value = redis.ListRange(key,0,-1);
	foreach k in value do
		redislua.analysis(k);
	end 
	return value;
end

function sortedSet( key )
	local value = redis.SortedSetRangeByScore(key);
	foreach k in value do
		redislua.analysis(k);
	end 
	return value;
end


-- 获取key列表
redislua.input = function () 
	return redis_helper.Scanner("*smallactivity_rescordtop_key_*");
end

--分析代码
redislua.analysis = function( value )
	 print("redislua.analysis",value);
end


--执行器,支持异步
redislua.exec = function (input)  
    local key_type = redis.KeyType(input);
	--[[if(key_type~='String')then
		return;
	end ]]
	local switch = {
		SortedSet = sortedSet,
		List = listGet,
		String = stringGet
	}
	local cmd = switch[key_type];
	if cmd then
		cmd(input);
	else
		print("The type was not found ==> ",key_type);
	end
	return cmd;
end

return redislua;