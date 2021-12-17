using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace HW_4
{
    public static class HSECompany
    {
        public const uint MaxCount = 5;

        private static ConnectionMultiplexer _redis;
        private static IDatabase _database;
        private static IServer _server;

        public static void Connect()
        {
            _redis = ConnectionMultiplexer.Connect(
                "redis-19464.c250.eu-central-1-1.ec2.cloud.redislabs.com:19464,password=xRlElIOTQqOOdHnj5bPX0BvSguhVGNK8,ConnectTimeout=10000,allowAdmin=true");
            _database = _redis.GetDatabase();
        }
        private static bool Exist(string key)
        {
            return _database.KeyExists(key);
        }
        private static void SetValue(string key, string value)
        {
            _database.ListRightPush(key, value);
        }
        public static string GetValue(string key, int index=-1)
        {
            if (index == -1)
                return _database.StringGet(key);
            return _database.ListGetByIndex(key, index);
        }
        public static void Add(string key, string value)
        {
            if (_database.ListLength(key) >= MaxCount)
            {
                Console.WriteLine("Too many versions are being stored. The first one will has been deleted.");
                _database.ListLeftPop(key);
            }
            SetValue(key, value);
            Console.WriteLine($"New update v{value}");
        }

        public static void Back(string key)
        {
            if (Exist(key) && _database.ListLength(key) != 1)
            {
                _database.ListRightPop(key);
                Console.WriteLine(
                    $"App backed to version {GetValue(key, (int)_database.ListLength(key) - 1)}");
            }
            else
            {
                _database.KeyDelete(key);
                Console.WriteLine("No prev version! App deleted!");
            }
        }

        public static void Get(string key)
        {
            if (Exist(key))
                Console.WriteLine($"{key} is {_database.ListGetByIndex(key, _database.ListLength(key) - 1)}");
            else
                Console.WriteLine("No app found");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HSECompany.Connect();
            string command = Console.ReadLine();
            bool flag = true;
            while (flag)
            {
                string app, version;
                if (command.StartsWith("add"))
                {
                    string[] input = command.Split(' ');
                    (app, version) = (input[1], input[2]);
                    HSECompany.Add(app, version);
                }
                else if (command.StartsWith("back"))
                {
                    string[] input = command.Split(' ');
                    HSECompany.Back(input[1]);
                }
                else if (command.StartsWith("get"))
                {
                    string[] input = command.Split(' ');
                    HSECompany.Get(input[1]);
                }
                else if (command.StartsWith("exit"))
                    flag = false;
                else
                    Console.WriteLine("UNKWN COMMAND");
                if(flag)
                    command = Console.ReadLine();
            }
        }
    }
}