using System;
using System.IO;
using System.Text.Json;

namespace TwitterBirdBot
{
    // TODO - Dani: try to understand how it works and ask questions
    // Try to run and test it in Program.Main()
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
        public String Host { get; set; }
        public Int64 Port { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }
        public String Name { get; set; }
    }

    public class SQLite
    {
        public String Path { get; set; }
    }

    public class Telegram
    {
        public String Token { get; set; }
    }

    public class Twitter
    {
        public String Token { get; set; }
    }

    public class Config
    {
        public MySQL MySQL { get; set; }
        public SQLite SQLite { get; set; }
        public Telegram Telegram { get; set; }
        public Twitter Token { get; set; }
    }
}
