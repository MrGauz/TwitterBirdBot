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

    public class MySQLConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
    }

    public class SQLiteConfig
    {
        public string Path { get; set; }
    }

    public class TelegramConfig
    {
        public string Token { get; set; }
    }

    public class TwitterConfig
    {
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string OAuthToken { get; set; }
        public string AccessToken { get; set; }
    }

    public class Config
    {
        public MySQLConfig MySQL { get; set; }
        public SQLiteConfig SQLite { get; set; }
        public TelegramConfig Telegram { get; set; }
        public TwitterConfig Twitter { get; set; }
    }
}
