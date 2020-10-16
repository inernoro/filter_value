
local com = {};
local json = clr.filter_value.datasource.help; 

--userdata 转 json
com.ud2json = function ( userdata )
	return json.Serialize(userdata);
end
--luatable 转 json
com.lt2json = function ( luatable )
	return json.ToJson(luatable);
end

--string 转 luatable
com.str2lt = function ( str )
	return json.Deserialize(str);
end

com.toobejct = function ( str )
	return com.str2lt(str);
end

com.tostring = function ( luatable )
    return json.Serialize(luatable);
end

--需要提供两个参数
com.save = function ( data , file_name )
	json.save(data,file_name);
end



return com;