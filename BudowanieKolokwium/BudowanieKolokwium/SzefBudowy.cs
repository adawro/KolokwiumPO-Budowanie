using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowanieKolokwium
{
    class SzefBudowy
    {
       private ProjektDomu projektDomu;

        public void WybierzProjekt (ProjektDomu projekt)
        {
            projektDomu = projekt;
        }
        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {
            projektDomu.NowyDom();
            projektDomu.WstawOkna(rodzajOkien);
            projektDomu.ZamontujDrzwi(rodzajDrzwi);
            projektDomu.PomalujElewacje(kolor);
        }
        
    }
}
