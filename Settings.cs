using System;
using System.IO;
using System.Text.Json;

namespace TwitterBirdBot
{
    public class Settings
    {
        public static readonly Config Config;
        static Settings()
        {
            string jsonString = File.ReadAllText("config.json");
            Config = JsonSerializer.Deserialize<Config>(jsonString);
        }
    }

    public class MySQL
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
    }

    public class SQLite
    {
        public string Path { get; set; }
    }

    public class Telegram
    {
        public string Token { get; set; }
    }

    public class Twitter
    {
        public string Token { get; set; }
    }

    public class Config
    {
        public MySQL MySQL { get; set; }
        public SQLite SQLite { get; set; }
        public Telegram Telegram { get; set; }
        public Twitter Twitter { get; set; }
    }
}
