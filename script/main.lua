--替换此部分就能换重载 
local lib = require("script/command")
local com = require("script/com");

--分析代码
lib.analysis2 = function( value ) 
	 local lt = com.str2lt(value)
	 if (lt["SmallCustomerNickName"] == "MKL-莫") then
		for k,v in pairs(lt) do
	 		print(k,v)
		end
	 end
end

lib.analysis3 = function ( value )
if(string.find(value, "B200060:"))then
	print(value);
end
end

--必须,每个操作完延迟时间
function delay(state)
	return 10;
end

--完成后是否停止操作
function complete_stop()
	return true;
end

--输入值,触发的入口
function input()
	return lib.input();
end

--输出值,分析值,每个入口对应多少个操作
function exec(input)
	return lib.exec(input);
end
