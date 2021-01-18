using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen.MageSpells
{
    public class FireBall : ISkill
    {
        public string Name { get; set; }
        public FireBall()
        {
            Name = "Fireball";
        }
        public int Cast()
        {
            return 1;
        }
    }
}
