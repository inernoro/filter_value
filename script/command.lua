local command = {};

local sum = {};
local index = 0;
local help = clr.filter_value.datasource.help;
local config = clr.filter_value.com.GetConfig;

command.analysis = function(value)
   --过滤掉其他
    if(
    string.find(value, " \"UNSUBSCRIBE\" ") 
    or string.find(value, " \"ECHO\" ")
    or string.find(value, " \"RPUSH\" ")
    )then 
        return;
    end
    local newdata = value;
	newdata = help.Split(value, ' ', '\"');
	newdata = getlast(newdata);
    if (not newdata) then return; end
    if (sum[newdata]) then
        sum[newdata] = sum[newdata] + 1;
    else
        sum[newdata] = 1;
    end
    index = index + 1;
    local count = config.Get("command_print_count",100);
    --print(count,math.fmod(index, count));
    if (math.fmod(index, tonumber(count)) == 0) then print_sum(); end
    --print("redislua.analysis ==> ", value, newdata);
end

function getlast(value) 
    local inx = 0;
	foreach item in value do
    inx = inx +1;
        if(inx == 5) then
            return item;
        end
	end
end

function print_sum()
  local  kindex=0;
	for key, value in pairs(sum) do
        kindex = kindex + 1;
		print(key, value);
	end
    print("===============sum===============",kindex);
end

command.input = function()
    local data = clr.System.Console.ReadLine();
    return data;
end

command.exec = function(value) command.analysis(value); end

return command;
