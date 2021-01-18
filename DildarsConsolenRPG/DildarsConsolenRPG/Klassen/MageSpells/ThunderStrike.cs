﻿using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen.MageSpells
{
    public class ThunderStrike: ISkill
    {

        public string Name { get; set; }
        public ThunderStrike()
        {
            Name = "Blitz irgendwas";
        }
        public int Cast()
        {
            return 1;
        }
    }
}
