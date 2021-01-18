using System;

namespace AdapterPattern
{
    internal class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
