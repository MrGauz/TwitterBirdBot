using LinqToTwitter;
using TwitterBirdBot.Models;

namespace TwitterBirdBot.SocialNetworks
{
    public class Twitter
    {
        public Twitter()
        {
            var auth = new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = Settings.Config.Twitter.ConsumerKey,
                    ConsumerSecret = Settings.Config.Twitter.ConsumerSecret,
                    OAuthToken = Settings.Config.Twitter.OAuthToken,
                    AccessToken = Settings.Config.Twitter.AccessToken
                }
            };
        }

        public static bool IsValidHandle(string handle)
        {
            // TODO - Gauz: validate handle
            return true;
        }

        public static Tweet GetLastTweet(string handle)
        {
            // TODO - Gauz: get last tweet
            return new Tweet();
        }
    }
}
