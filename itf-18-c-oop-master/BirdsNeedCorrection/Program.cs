using System;

namespace BirdsNeedCorrection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create a Sparrow
            Sparrow sparrow = new Sparrow();

            // Create a interface of type PlasticToyDuck
            ToyDuck toyDuck = new PlasticToyDuck();

            // Put a sparrow into the bird adapter to make it behave like a sparrow
            ToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Calling Fly() and MakeSound() on sparrow");
            sparrow.Fly();
            sparrow.MakeSound();

            Console.WriteLine("Calling Squeak() on toyDuck");
            toyDuck.Squeak();

            Console.WriteLine("Calling Squeak() on birdAdapter");
            birdAdapter.Squeak();

            Console.ReadKey();
        }
    }
}
