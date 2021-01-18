using System;

namespace RPGNeedsCorrection
{
    internal class FiryBoi : Adaptee
    {
        internal FiryBoi() : base(99999, 99999)
        {

        }

        internal override void Attack(Adaptee xTarget)
        {
            Console.WriteLine("Firy BOIII attacks with its FIRY ATTACKS!");
            xTarget.HP -= 25;
            xTarget.MP -= 5;
            Console.WriteLine("THAT WAS SOME HOT STUFF!");
        }
    }
}
