using System;

namespace AdapterPattern
{
    internal class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Specific Request()");
        }
    }
}
