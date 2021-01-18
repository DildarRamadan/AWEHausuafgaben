using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen.DragonSpells
{
    public class FireBreathing: ISkill
    {
        public string Name { get; set; }
        public FireBreathing()
        {
            Name = "Feuer ATTACKE buh";
        }
        public int Cast()
        {
            return 1;
        }
    }
}
