
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

return com;