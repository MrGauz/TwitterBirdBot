using System;

namespace TwitterBirdBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Dani: try running it           
            Settings.Initialize();
            Console.WriteLine(Settings.Config.Database.Host);
        }
    }
}
