using System;
using StackExchange.Redis;
namespace Task_2
{
    class StorageLife
    {
        public const uint MaxCount = 5;

        private static ConnectionMultiplexer _redis;
        private static IDatabase _database;
        private static IServer _server;

        public static void Connect()
        {
            _redis = ConnectionMultiplexer.Connect(
                "redis-19041.c250.eu-central-1-1.ec2.cloud.redislabs.com:19041,password=OYxY2FxNcp695AFVQGkEx7QtIbHJBpDh,ConnectTimeout=10000,allowAdmin=true");
            _database = _redis.GetDatabase();
        }
        public static void Add(string key, string value)
        {
            _database.SetAdd(key, value);
        }
        
        public static string[] Get(string key)
        {
            if (_database.KeyExists(key))
            {
                return _database.SetMembers(key).ToStringArray();
            }
            return new string[0];
        }

        public static bool Exist(string key, string value) => _database.SetContains(key, value);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}