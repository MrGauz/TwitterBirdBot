using System;

namespace TwitterBirdBot.Models
{
    public enum SocialNetworkType
    {
        Twitter
    }
    public class Subscription
    {
        // TODO - Dani:
        // create attributes with getters and setters 
        // for each table column to map DB table to model
        //
        // ``tg_user_id``       string      Telegram user ID
        // ``social_network``   enum        SocialNetworkType
        // ``show_links``       bool        Embed links to user and tweet in messages
        // ``subscribed_at``    timedate    When subscription was created
        // ``last_post_id``     string      Last delivered post ID or timestamp
        // ``last_post_at``     datetime    Last delivered post ID or timestamp

        // i.e. tg_user_id
        public String TgUserId { get; set; }
    }
}
