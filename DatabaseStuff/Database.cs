using System.Collections.Generic;
using TwitterBirdBot.Models;

namespace TwitterBirdBot.DatabaseStuff
{
    public class Database
    {
        public static void AddSubscription(Subscription subscription)
        {
            SqliteConnections.AddSubscription(subscription);
        }

        public static List<Subscription> GetSubscriptions(string tgUserId)
        {
            return SqliteConnections.GetSubscriptions(tgUserId);
        }

        public static List<Subscription> GetSubscriptions(SocialNetworkType socialNetworkType)
        {
            return SqliteConnections.GetSubscriptions(socialNetworkType);
        }
    }
}
