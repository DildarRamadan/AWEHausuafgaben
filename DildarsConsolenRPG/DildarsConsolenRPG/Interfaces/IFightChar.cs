using DildarsConsolenRPG.Klassen.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Interfaces
{
    public interface IFightChar
    {
        int MaxHealth { get; set; }
        int CurrentHealt { get; set; }

        CharacterState CharacterState { get; set; }

        int DMGPoints { get; set; }
        int CritChance { get; set; }

        List<ISkill> Skills { get; set; }

        CastResponse CastSpell(ISkill skill);
        void GetDmg(int dmg);
        bool AmIDeeeeead();
    }
}
