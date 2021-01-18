using DildarsConsolenRPG.Interfaces;
using DildarsConsolenRPG.Klassen.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen
{
    public abstract class Mage : IMage
    {
        public int MaxHealth { get; set; }
        public int CurrentHealt { get; set; }
        public CharacterState CharacterState { get; set; }
        public int DMGPoints { get; set; }
        public int CritChance { get; set; }
        public List<ISkill> Skills { get; set; }

        public CharacterState Power { get; set; }

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
                response.Damage = (int)Math.Round(response.Damage * 0.20);
            }

            if (rnd.Next(0, 100) <= 31)
                response.State = Power;

            return response;
        }

        public void GetDmg(int dmg)
        {
            this.CurrentHealt = CurrentHealt - dmg;
            if(CurrentHealt <=0)
                Console.WriteLine("wallah der mage ist tot");
        }

        public void UseHumanSpecialPower()
        {
            Console.WriteLine("Er ist beim versuch dieser Fähigkeit zu casten gestorben. Ich bitte um ein F für den Bruder...");
        }
    }
}
