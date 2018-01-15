using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowanieKolokwium
{
    abstract public class ProjektDomu
    {
        public Dom dom = new Dom();
        public void NowyDom()
        {
            Dom dom = new Dom();
           
        }

        public  void WstawOkna(string rodzajOkien)
        {
            dom.WstawOkna(rodzajOkien);
        }
        public void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi(rodzajDrzwi);
        }
        public abstract void PomalujElewacje(Kolor kolor);
       
        public override string ToString()
        {
            return dom.ToString();
        }
    }
}
