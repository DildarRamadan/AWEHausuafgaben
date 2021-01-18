using AdapterPater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPater.Klassen
{
    public class WilderTruthanii : ITruthan
    {
        public void Fliegen()
        {
            Console.WriteLine("ich bin eine WilderTruthanii und fliege wie eine WilderTruthanii");

        }

        public void Kollern()
        {
            Console.WriteLine("ich bin eine WilderTruthanii und koller wie eine WilderTruthanii");

        }
    }
}
