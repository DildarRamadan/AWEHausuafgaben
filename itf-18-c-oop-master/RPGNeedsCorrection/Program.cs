using System;
using System.Collections.Generic;

namespace RPGNeedsCorrection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Adaptee> lxHumans = new List<Adaptee>();
            lxHumans.Add(new Magus());
            lxHumans.Add(new Waldo());
            lxHumans.Add(new FiryBoi());
            lxHumans.Add(new HealerTobias());

            StoryTeller xTeller = new StoryTeller(lxHumans);
            xTeller.StartStory();

            Console.ReadKey();
        }
    }
}
