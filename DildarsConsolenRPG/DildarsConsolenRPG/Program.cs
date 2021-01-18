using DildarsConsolenRPG.Interfaces;
using DildarsConsolenRPG.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG
{
    class Program
    {
        static void Main()
        {
            IDrache drache;
            IMage magier;
            Console.Write("Willkommen zum Spiel");
            A();
            Console.Write("Momentan befindest du dich in der Char auswahl");
            drache = GetDragon();
#pragma warning disable IDE0059 // Unnötige Zuweisung eines Werts.
            Console.WriteLine("dein Gegner ist:");
            magier = CharacterErstellService.PeterDerEisMagier();
#pragma warning restore IDE0059 // Unnötige Zuweisung eines Werts.
            A();
            A();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Drache lebenspukte:"+ drache.CurrentHealt);
                Console.WriteLine("Mage lebenspukte:" + magier.CurrentHealt);

                Console.WriteLine("Drache ist am zug");
                A();
                Console.WriteLine("waehle eine Attacke");
                Console.WriteLine("1: "+drache.Skills[0].Name);
                A();
                A();
                var dmgdrache = drache.CastSpell(drache.Skills[0]).Damage;
                Console.WriteLine($"der drache greift an mit {dmgdrache} dmg");
                magier.GetDmg(dmgdrache);


                Console.ReadLine();
                if (magier.AmIDeeeeead())
                {
                    Console.WriteLine("drache gewinnt...");
                    Console.WriteLine("was hast du auch erwartet? ein mage gegen ne scheiß riesen Echse...");
                    break;
                }
                A();
            }
        }


        static IDrache GetDragon()
        {
            Console.Clear();
            A();
            Console.WriteLine("Wähle zunächst einen Drachen aus.");
            Console.WriteLine("Du kannst zwischen 3 verschidene Drachen wählen, welche sich eig. nicht unterscheiden");
            Console.WriteLine("1. Eis Drache Gustav");
            Console.WriteLine("2. Feuer Drache");
            Console.WriteLine("3. Blitz Drache");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Eis also. AHA...");
                    return CharacterErstellService.DragonKalto();
                case "2":
                    Console.WriteLine("Feuer? sehr sehr schwach von dir...");
                    return CharacterErstellService.DragonFeueri();
                case "3":
                    Console.WriteLine("Blitzdrache... die gibt es doch gar net ");
                    return CharacterErstellService.DragonSchocki();
                default:
                    Console.WriteLine("BENUTZE ZAHLEN!");
                    break;
            }
            return new IceDragon();
        }
        static int A()
        {
            return Console.Read();
        }
    }
}
