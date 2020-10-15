namespace filter_value.datasource.redis
{
    public static class CacheConfigurage
    {
        public static string redis_password { get; set; } 
        public static int redis_default_database { get; set; }
        public static string ConnectionString { get; set; }
    }
}
