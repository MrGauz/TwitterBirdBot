using System;
using System.IO;
using System.Text.Json;

namespace TwitterBirdBot
{
    // TODO - Dani: try to understand how it works and ask questions
    // Try to run and test it in Program.Main()
    public class Settings
    {
        public static Config Config;
        public static void Initialize()
        {
            string jsonString = File.ReadAllText("config.json");
            Config = JsonSerializer.Deserialize<Config>(jsonString);
        }
    }

    public class Database
    {
        public String Host { get; set; }
        // TODO - Dani: add int "Port" attribute
        // TODO - Dani: add "User" attribute
        // TODO - Dani: add "Pass" attribute
        // TODO - Dani: add "Database" attribute
    }
    public class Config
    {
        public Database Database { get; set; }
        // TODO - Dani: based on Database, build classes for Telegram
        // see config.json.example
    }
}
