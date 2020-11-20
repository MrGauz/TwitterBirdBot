using System;

namespace TwitterBirdBot.Models
{
    public enum SocialNetworkType
    {
        Twitter
    }
    public class Subscription
    {
        public string TgUserId { get; set; }
        public SocialNetworkType SocialNetwork { get; set; }
        public string SocialNetworkString
        {
            set
            {
                SocialNetworkType name;
                Enum.TryParse(value, out name);

                SocialNetwork = name;
            }
        }
        public bool ShowLinks { get; set; }
        public DateTime SubscribedAt { get; set; }
        public string LastPostId { get; set; }
        public DateTime LastPostAt { get; set; }
    }
}
