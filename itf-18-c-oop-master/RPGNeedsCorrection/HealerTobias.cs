using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGNeedsCorrection
{
    internal class HealerTobias : Adaptee
    {
        internal HealerTobias() : base(1000, 20000)
        {

        }

        internal override void Attack(Adaptee xTarget)
        {
            Console.WriteLine("SRY I AM A PACIFIST!");
        }
        internal override void Heal(Adaptee xTarget)
        {
            xTarget.HP += 25;
            Console.WriteLine($"Here, have sum juice from mah roots, {xTarget.GetType()}");
        }
    }
}
