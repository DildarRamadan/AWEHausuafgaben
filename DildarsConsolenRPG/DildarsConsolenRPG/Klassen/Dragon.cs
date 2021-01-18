using DildarsConsolenRPG.Interfaces;
using DildarsConsolenRPG.Klassen.helper;
using System;
using System.Collections.Generic;

namespace DildarsConsolenRPG.Klassen
{
    public abstract class Dragon : IDrache
    {
        public int MaxHealth { get; set; }
        public int CurrentHealt { get; set; }
        public CharacterState CharacterState { get; set; }
        public int DMGPoints { get; set; }
        public int CritChance { get; set; }
        public List<ISkill> Skills { get; set; }

        public CharacterState  Power { get; set; }

        public bool AmIDeeeeead()
        {
            if (CurrentHealt <= 0)
                return true;
            else
                return false;
        }

        public CastResponse CastSpell(ISkill skill)
        {
            var rnd = new Random();

            CastResponse response = new CastResponse()
            {
                Damage = skill.Cast() * DMGPoints

            };
            
            if (rnd.Next(0, 101) <= CritChance)
            {
                Console.WriteLine("yeeet, CRIT!");
                response.Damage = (int)Math.Round(response.Damage * 1.20);
            }
            if (rnd.Next(0, 100) <= 21)
                response.State = Power;

            return response;
        }

        public void FlyAway()
        {
            Console.WriteLine("HE NEED SOME MILK!");
        }

        public void GetDmg(int dmg)
        {
            this.CurrentHealt = CurrentHealt - dmg;
            if (CurrentHealt <= 0)
                Console.WriteLine("wallah der drache schläft nur");
        }
    }
}
