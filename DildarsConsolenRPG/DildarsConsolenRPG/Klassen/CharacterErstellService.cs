using DildarsConsolenRPG.Interfaces;
using DildarsConsolenRPG.Klassen.DragonSpells;
using DildarsConsolenRPG.Klassen.MageSpells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen
{
    public static class CharacterErstellService
    {
        public static IceDragon DragonKalto()
        {
            Console.WriteLine("Du bekommst den Drachen Namens Kalto");
            return new IceDragon()
            {
                Power = CharacterState.freezed,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 1000,
                CurrentHealt = 1000,
                DMGPoints = 400,
                Skills = new List<ISkill>()
                {
                    new IceBreathing()
                }
            };
        }

        public static FireDragon DragonFeueri()
        {
            Console.WriteLine("der drachen den du bekommst heißt feueri");
            return new FireDragon()
            {
                Power = CharacterState.burned,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 1000,
                CurrentHealt = 1000,
                DMGPoints = 400,
                Skills = new List<ISkill>()
                {
                    new FireBreathing()
                }
            };
        }

        public static ThunderDragon DragonSchocki()
        {
            Console.WriteLine("es gibt immer noch keine Blitzdrachen");
            return new ThunderDragon()
            {
                Power = CharacterState.shocked,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 1000,
                CurrentHealt = 1000,
                DMGPoints = 400,
                Skills = new List<ISkill>()
                {
                    new ThunderBreathing()
                }
            };
        }

        public static IceMage PeterDerEisMagier()
        {
            Console.WriteLine("Eis, eis, eis Peter Eis");
            return new IceMage()
            {
                Power = CharacterState.shocked,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 20,
                CurrentHealt = 20,
                DMGPoints = 1,
                Skills = new List<ISkill>()
                {
                    new IceStrike()
                }
            };
        }

        public static FireMage HansDerFeuerMagier()
        {
            Console.WriteLine("Hans der mit dem Feuer spielt");
            return new FireMage()
            {
                Power = CharacterState.shocked,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 10,
                CurrentHealt = 10,
                DMGPoints = 1,
                Skills = new List<ISkill>()
                {
                    new FireBall()
                }
            };
        }

        public static ThunderMage ReinerDerSchockierende()
        {
            Console.WriteLine("Blitz Magier könnte es geben. Du bist jetzt Reiner der Schockierende");
            return new ThunderMage()
            {
                Power = CharacterState.shocked,
                CharacterState = CharacterState.normal,
                CritChance = 10,
                MaxHealth = 10,
                CurrentHealt = 10,
                DMGPoints = 1,
                Skills = new List<ISkill>()
                {
                    new ThunderStrike()
                }
            };
        }

    }
}
