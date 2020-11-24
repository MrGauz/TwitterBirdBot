using System;

namespace TwitterBirdBot.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public string UserHandle { get; set; }
        public DateTime Timestamp { get; set; }
        public string Text { get; set; }
        public Uri Link { get; set; }
        public Uri UserLink => new Uri("https://twitter.com/" + UserHandle);
        // TODO - Gauz: add List<TweetPictures>

        public string ToMessage()
        {
            // TODO - Dani: compose msg with this tweet to send to user (with links and shit)
            // Use HTML or MD
            return $"";
        }
    }
}
