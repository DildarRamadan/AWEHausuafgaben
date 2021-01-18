using AdapterPater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPater.Adapter
{
    public class EnteAdapter : ITruthan
    {
        public IEnte Ente{ get; set; }

        public EnteAdapter(IEnte ente)
        {
            Ente = ente;
        }

        public void Fliegen()
        {
            Ente.Fliegen();
        }

        public void Kollern()
        {
            Ente.Quacken();
        }
    }
}
