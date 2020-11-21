using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using TwitterBirdBot.Models;

namespace TwitterBirdBot.DatabaseStuff
{
    public class SqliteConnections
    {
        private static readonly SqliteConnection Connection;

        static SqliteConnections()
        {
            String sqlitePath = Settings.Config.SQLite.Path;

            bool newFile = false;
            if (!File.Exists(sqlitePath))
            {
                newFile = true;
            }

            string connectionString = $"Data Source={sqlitePath}";
            Connection = new SqliteConnection(connectionString);
            Connection.Open();

            if (newFile)
            {
                var query = Connection.CreateCommand();
                query.CommandText = "BEGIN TRANSACTION;" +
                                    "CREATE TABLE \"subs\" (" +
                                        "\"id\"              INTEGER      NOT NULL," +
                                        "\"tg_user_id\"      varchar(50)  NOT NULL," +
                                        "\"social_network\"  varchar(50)  NOT NULL   DEFAULT 'Twitter'," +
                                        "\"show_links\"      bool         NOT NULL   DEFAULT true," +
                                        "\"subscribed_at\"   datetime     NOT NULL," +
                                        "\"last_post_id\"    varchar(50)  NOT NULL," +
                                        "\"last_post_at\"    datetime     NOT NULL," +
                                        "PRIMARY KEY(\"id\" AUTOINCREMENT)" +
                                    ");" +
                                    "COMMIT;";
                try
                {
                    query.ExecuteNonQuery();
                }
                catch (SqliteException ex)
                {
                    Console.WriteLine($"{ex.Message} (sqlite code: {ex.SqliteErrorCode})\n" + ex.StackTrace);
                }
            }
        }
        public static void AddSubscription(Subscription subscription)
        {
            var query = Connection.CreateCommand();
            // TODO - Dani: comlete INSERT command
            // Then test if it works in Program.Main()
            query.CommandText = $"INSERT INTO subs " +
                $"('tg_user_id', '', '', '') " +
                $"VALUES " +
                $"('{subscription.TgUserId}', '', '', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}');";
            try
            {
                query.ExecuteNonQuery();
            }
            catch (SqliteException ex)
            {
                Console.WriteLine($"{ex.Message} (sqlite code: {ex.SqliteErrorCode})\n" + ex.StackTrace);
            }
        }

        public static List<Subscription> GetSubscriptions(string tgUserId)
        {
            throw new NotImplementedException();
        }

        public static List<Subscription> GetSubscriptions(SocialNetworkType socialNetworkType)
        {
            throw new NotImplementedException();
        }
    }
}
