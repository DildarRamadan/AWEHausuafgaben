using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGNeedsCorrection
{
    class Olaf : Adaptee
    {
        internal Olaf() : base(999999999, -9999999)
        {

        }

        internal override void Attack(Adaptee xTarget)
        {
            xTarget.HP -= 99;
            Console.WriteLine("HORST!");
        }
    }
}
