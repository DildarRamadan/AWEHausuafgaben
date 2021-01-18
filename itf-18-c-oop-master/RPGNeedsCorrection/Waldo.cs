using System;

namespace RPGNeedsCorrection
{
    internal class Waldo : Adaptee
    {
        internal Waldo() : base(1, 0)
        {

        }

        internal override void Attack(Adaptee xTarget)
        {
            Console.WriteLine("SRY I AM A PACIFIST!");
        }
    }
}
