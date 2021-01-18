using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen.DragonSpells
{
    public class IceBreathing: ISkill
    {

        public string Name { get; set; }
        public IceBreathing()
        {
            Name = "Eis ATTACKE buh";
        }
        public int Cast()
        {
            return 1;
        }
    }
}
