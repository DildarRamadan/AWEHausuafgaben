using DildarsConsolenRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Klassen

{
    public class IceMage : Mage, IMage
    {
        // hier stehen sachen die nur ein Eis??? Magier? machen kann
        public IceMage()
        {
            this.Power = CharacterState.freezed;
        }
    }

    public class FireMage : Mage, IMage
    {
        // hier stehen sachen die nur ein feuer? magier? machen kann
        public FireMage()
        {
            this.Power = CharacterState.burned;
        }
    }

    public class ThunderMage : Mage, IMage
    {
        // hier stehen sachen die nur ein blitz? magier? machen kann
        public ThunderMage()
        {
            this.Power = CharacterState.shocked;
        }
    }

}
