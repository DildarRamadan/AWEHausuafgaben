using AdapterPater.Interface;
using AdapterPater.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPater.Adapter
{
    /// <summary>
    /// truthan wie ente
    /// </summary>
    public class TruthanAdapter : IEnte
    {
        public ITruthan Truthan { get; set; }

        public TruthanAdapter(ITruthan truthan)
        {
            Truthan = truthan;
        }

        public void Fliegen()
        {
            Truthan.Fliegen();
        }

        public void Quacken()
        {
            Truthan.Kollern();
        }
    }
}
