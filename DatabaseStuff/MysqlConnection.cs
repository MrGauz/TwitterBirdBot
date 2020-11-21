using System;
using System.Collections.Generic;
using TwitterBirdBot.Models;

namespace TwitterBirdBot.DatabaseStuff
{
    public class MysqlConnection
    {
        static MysqlConnection()
        {
            // TODO - Gauz: Do the whole fucking thing, c'mon
        }
        public static void AddSubscription(Subscription subscription)
        {
            // TODO - Dani: convert SQLite query to MySQL
            // Google differences in CREATE TABLE command
            // Code in Database/SQLite.cs
            string queryString = "CREATE TABLE \"subs\" (" +
                                    "\"id\" INTEGER NOT NULL," +
                                    "..." +
                                 ");";
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
