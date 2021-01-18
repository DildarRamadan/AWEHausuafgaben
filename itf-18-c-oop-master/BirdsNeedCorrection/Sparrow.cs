using System;

namespace BirdsNeedCorrection
{
    internal class Sparrow : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void MakeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
