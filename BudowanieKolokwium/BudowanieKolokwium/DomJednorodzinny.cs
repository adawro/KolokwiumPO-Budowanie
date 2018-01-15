using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowanieKolokwium
{
    class DomJednorodzinny:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            kolor = Kolor.Czerwony;
            dom.PomalujElewacje(kolor);
        }

        public override string ToString()
        {
            return "Dom Jendorodzinny:" + base.ToString();
        }
    }
}
