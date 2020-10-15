--替换此部分就能换重载 
local lib = require("script/redis")
local com = require("script/com");
 
lib.analysis = function( value ) 
	 local lt = com.str2lt(value) 
	 --if (string.find(lt["SmallCustomerNickName"],"MKL-莫")>0) then
	 if (lt["SmallCustomerNickName"] == "MKL-莫") then
		for k,v in pairs(lt) do
	 		print(k,v)
		end
	 end
	 

end

--必须
function delay(state)
	return 10;
end

--必须
function complete_stop()
	return true;
end

function input()
	return lib.input();
end

--必须
function exec(input)
	return lib.exec(input);
end
