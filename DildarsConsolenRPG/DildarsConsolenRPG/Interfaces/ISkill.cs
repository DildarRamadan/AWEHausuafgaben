using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DildarsConsolenRPG.Interfaces
{
    public interface ISkill
    {
        string Name { get; set; }
        int Cast();
    }
}
