using Microsoft.Data.Sqlite;
using System;
using System.IO;
using TwitterBirdBot.Models;

namespace TwitterBirdBot
{
    public class Database
    {
#if DEBUG
        public static readonly SqliteConnection Connection;
#else
        // TODO - Gauz: MySQL connection
#endif
        static Database()
        {
#if DEBUG
            Connection = InitializeSQLite();
#else
    //TODO - Gauz: MySQL connection
#endif
        }

        private static SqliteConnection InitializeSQLite()
        {
            String sqlitePath = Settings.Config.SQLite.Path;

            bool newFile = false;
            if (!File.Exists(sqlitePath))
            {
                newFile = true;
            }

            string connectionString = $"Data Source={sqlitePath}";
            SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            if (newFile)
            {
                var query = connection.CreateCommand();
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

            return connection;
        }

        public static void AddSubscription(Subscription sub)
        {
            // TODO - Gauz: write skeleton
            // TODO - Dani: complete method           
        }
    }
}
