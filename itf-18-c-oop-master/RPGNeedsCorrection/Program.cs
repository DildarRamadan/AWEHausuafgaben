using System;
using System.Collections.Generic;

namespace RPGNeedsCorrection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Target> lxHumans = new List<Target>();
            lxHumans.Add( new Adapter(new Magus()));
            lxHumans.Add(new Adapter(new Waldo()));
            lxHumans.Add(new Adapter(new FiryBoi()));
            lxHumans.Add(new Adapter(new HealerTobias()));

            StoryTeller xTeller = new StoryTeller(lxHumans);
            xTeller.StartStory();

            Console.ReadKey();
        }
    }
}
