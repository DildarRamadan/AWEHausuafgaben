using System;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Target xTarget = new Target();
            xTarget.Request();

            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
