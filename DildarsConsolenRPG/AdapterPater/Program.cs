using AdapterPater.Adapter;
using AdapterPater.Interface;
using AdapterPater.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPater
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnte Ente = new StockEntiii();
            Ente.Quacken();
            Ente.Fliegen();
            Console.WriteLine("_______________");

            ITruthan Truthan = new WilderTruthanii();
            Truthan.Kollern();
            Truthan.Fliegen();
            Console.WriteLine("_______________");

            Console.WriteLine("Fake startet");
            Console.WriteLine("_______________");
            IEnte FakeEnte = new TruthanAdapter(Truthan);
            FakeEnte.Fliegen();
            FakeEnte.Quacken();

            Console.WriteLine("_______________");
            ITruthan fakeTruthan = new EnteAdapter(Ente);
            fakeTruthan.Fliegen();
            fakeTruthan.Kollern();
        }
    }
}
