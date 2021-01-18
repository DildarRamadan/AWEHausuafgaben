using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen.DragonSpells
{
    public class ThunderBreathing : ISkill
    {
        public string Name { get; set; }
        public ThunderBreathing()
        {
            Name = "blitz ATTACKE buh";
        }
        public int Cast()
        {
            return 1;
        }
    }
}
