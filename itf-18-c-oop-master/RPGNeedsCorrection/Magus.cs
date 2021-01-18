using System;

namespace RPGNeedsCorrection
{
    internal class Magus : Adaptee
    {
        internal Magus() : base(99, 99)
        {

        }

        internal override void Attack(Adaptee xTarget)
        {
            this.MP -= 5;
            xTarget.HP -= 15;
            Console.WriteLine("I FCKED THAT GUY UP, WITH MY MAGIC STUFF, I MEAN STAFF!");
        }
    }
}
