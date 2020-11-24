using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using TwitterBirdBot.DatabaseStuff;
using TwitterBirdBot.Models;
using TwitterBirdBot.SocialNetworks;

namespace TwitterBirdBot
{
    class Telegram
    {
        private static ITelegramBotClient Bot;
        private static Dictionary<int, CommandType> ActiveCommands;

        public Telegram()
        {
            Bot = new TelegramBotClient(Settings.Config.Telegram.Token);
            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            ActiveCommands = new Dictionary<int, CommandType>();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            int userId = e.Message.From.Id;
            string msg = e.Message.Text;

            switch (msg)
            {
                // New user
                case "/start":
                    // TODO - Dani: send a welcome message
                    break;

                // New subscription
                case "/add_sub":
                    // TODO - Dani: send message asking for twitter handle
                    ActiveCommands.Add(userId, CommandType.AddSubTwitter);
                    break;

                // Send "help" message
                case "/help":
                    // TODO - Dani: compose help message
                    break;

                default:
                    // Bot awaits response
                    if (ActiveCommands.ContainsKey(userId))
                    {
                        switch (ActiveCommands[userId])
                        {
                            case CommandType.AddSubTwitter:
                                if (Twitter.IsValidHandle(msg))
                                {
                                    Tweet lastTweet = Twitter.GetLastTweet(msg);
                                    
                                    Database.AddSubscription(new Subscription
                                    {
                                        TgUserId = userId.ToString(),
                                        SocialNetwork = SocialNetworkType.Twitter,
                                        ShowLinks = true,
                                        LastPostId = lastTweet.Id,
                                        LastPostAt = lastTweet.Timestamp
                                    });

                                    Telegram.SendMessage(userId, lastTweet.ToMessage(), ParseMode.Default);
                                    ActiveCommands.Remove(userId);
                                }
                                else
                                {
                                    // TODO - Dani: send message "invalid handle, bla-bla, try again"
                                }
                                break;
                        }
                    }
                    else
                    {
                        // Random message from user
                        // TODO - Dani: say something funny in response? Or tell 'em to piss off?
                    }
                    break;
            }
        }

        public static async void SendMessage(int userId, string msg, ParseMode parseMode)
        {
            await Bot.SendTextMessageAsync(
                chatId: userId,
                    text: msg,
                    parseMode: parseMode
                );
        }
    }
}
