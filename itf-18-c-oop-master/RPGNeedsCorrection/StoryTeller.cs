using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGNeedsCorrection
{
    internal class StoryTeller
    {
        private List<Adaptee> lxStoryParticipants = new List<Adaptee>();

        internal StoryTeller(List<Adaptee> lxHumans)
        {
            this.lxStoryParticipants = lxHumans;
        }

        internal void StartStory()
        {
            Story();
        }

        // Tells a story
        private void Story()
        {
            Console.WriteLine("Once upon a time, there was a retard, called Olaf. Olaf was happy because he didnt know how retarded he was.");
            Console.WriteLine("Thus he was on to a new adventure, with a mage called Magnus, and a Hide and Seek player Waldo.");
            Console.WriteLine("So they find a cave and wanted to explore it, they just ignored the corpes on the entrance.");
            Console.WriteLine("And they found a glowing mushroom, so Olaf thought he wants to it eat.");
            Console.WriteLine("So he became a drug addict, they needed to put him in a basement for the next 2 weeks.");
            Console.WriteLine("So they went also to the cave again and found a random dude sitting in a corner and fought the ferocious salamander hiding in the shadows...");
            Console.WriteLine("They might attack each other because they are a bit unique... and its dark... and they smelled the mushrooms too...");

            Console.WriteLine("Press any key to start the fight...");
            Console.ReadKey();

            Random xRND = new Random();

            // Runs as long as more than 1 is alive
            int iRounds = 1;
            while (true)
            {
                // Some random dude attacks some random dude
                lxStoryParticipants[xRND.Next(0, lxStoryParticipants.Count()) % iRounds].Attack(lxStoryParticipants[xRND.Next(0, lxStoryParticipants.Count()) % iRounds]);

                // Remove the corpses from the battlefield
                for (int i = lxStoryParticipants.Count() - 1; i >= 0; i--)
                {
                    if (lxStoryParticipants[i].IsDead)
                    {
                        lxStoryParticipants.Remove(lxStoryParticipants[i]);
                    }
                }

                // Stop the battle if only one or none survived
                if (lxStoryParticipants.Count() <= 1)
                {
                    break;
                }

                iRounds++;
                
                // Wait for the next round
                Task.Delay(1000).Wait();
            }

            // Check how many survived
            if (lxStoryParticipants.Count() == 1)
            {
                if (lxStoryParticipants[0].IsType() == typeof(FiryBoi))
                {
                    Console.WriteLine("Well the firy boi won.");
                }
                else if (lxStoryParticipants[0].IsType() == typeof(Magus))
                {
                    Console.WriteLine("At least one of them made it out of the cave alife. It wasnt Waldo tho.");
                }
                else
                {
                    Console.WriteLine("It is impossible, but Waldo made it somehow out of the cave... alife... alone...");
                }
            }
            else
            {
                Console.WriteLine("Seems like nobody made it... not even the firy boi");
            }
        }
    }
}
