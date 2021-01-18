using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen
{
    public class IceDragon : Dragon, IDrache
    {
        // hier stehen sachen die nur ein Eis Drache machen kann
        public IceDragon()
        {
            this.Power = CharacterState.freezed;
        }

        public static void Test()
        {
            Console.WriteLine("hallo");
        }
    }
    public class FireDragon : Dragon, IDrache
    {
        // hier stehen sachen die nur ein Feuer Drache machen kann
        public FireDragon()
        {
            this.Power = CharacterState.burned;
        }
    }
    public class ThunderDragon : Dragon, IDrache
    {
        // hier stehen sachen die nur ein Blitz Drache machen kann
        public ThunderDragon()
        {
            this.Power = CharacterState.shocked;
        }
    }
}
