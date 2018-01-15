using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowanieKolokwium
{
    class Biurowiec:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }
        public new void  ZamontujDrzwi(string rodzajDrzwi = "szklane")
        {
            
            dom.ZamontujDrzwi(rodzajDrzwi);
        }

        public override string ToString()
        {
            return "Biurowiec: " + base.ToString();
        }
    }
}
