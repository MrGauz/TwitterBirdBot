using System;

namespace TwitterBirdBot.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public string UserHandle { get; set; }
        public DateTime Timestamp { get; set; }
        public string Text { get; set; }

        public string ToMessage()
        {
            // TODO - Gauz
            return "";
        }
    }
}
