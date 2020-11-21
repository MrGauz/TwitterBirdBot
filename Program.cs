using TwitterBirdBot.DatabaseStuff;
using TwitterBirdBot.Models;

namespace TwitterBirdBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you do good in SqliteConnections, running this will add entry to db.sqlite
            // Go check it out!
            var s = new Subscription();
            s.TgUserId = "1234567";
            s.SocialNetwork = SocialNetworkType.Twitter;
            s.ShowLinks = false;          
            Database.AddSubscription(new Subscription());
        }
    }
}
