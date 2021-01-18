using AdapterPater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPater.Klassen
{
    public class StockEntiii : IEnte
    {
        public void Fliegen()
        {
            Console.WriteLine("ich bin eine StockEntiii und fliege wie eine StockEntiii");
        }

        public void Quacken()
        {
            Console.WriteLine("ich bin eine StockEntiii und quacke wie eine StockEntiii");

        }
    }
}
