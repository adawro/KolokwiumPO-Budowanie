using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudowanieKolokwium
{
    public enum Kolor { Biel, Czerwony, Zielony, Czarny };
    class Program
    {
        
        
            
        public static void menu()
        {
            Console.WriteLine("Co Chesz zrobic?");
            Console.WriteLine("A - buduj biurowiec");
            Console.WriteLine("B - buduj dom jednorodzinny");
            Console.WriteLine("X - koniec aplikacji ");
        }
        
        static void Main(string[] args)
        {
            Kolor kolor = Kolor.Biel;
            string decyzja = "";
            string drzwi = "";
            string okna = "";

            menu();
            do
            {
                decyzja = Console.ReadLine();
            if (decyzja == "A" || decyzja == "a")
            {
                //while (String.IsNullOrEmpty(drzwi))
                //{
                //    Console.WriteLine("Podaj rodzaj drzwi");
                //    drzwi = Console.ReadLine();
                //}
                while (String.IsNullOrEmpty(okna))
                {
                    Console.WriteLine("Podaj rodzja okien");
                    okna = Console.ReadLine();
                }
                
                ProjektDomu biuro = new Biurowiec();

                SzefBudowy szef = new SzefBudowy();
                szef.WybierzProjekt(biuro);

                szef.Buduj(okna, drzwi, kolor);

                Console.WriteLine("Zbudowano Biurowiec");
                Console.WriteLine(biuro.ToString());

            }

            if (decyzja == "B" || decyzja == "b")
            {
                while (String.IsNullOrEmpty(drzwi))
                {
                    Console.WriteLine("Podaj rodzaj drzwi");
                    drzwi = Console.ReadLine();
                }
                while (String.IsNullOrEmpty(okna))
                {
                    Console.WriteLine("Podaj rodzja okien");
                    okna = Console.ReadLine();
                }

                ProjektDomu dom = new DomJednorodzinny();

                SzefBudowy szef = new SzefBudowy();
                szef.WybierzProjekt(dom);

                szef.Buduj(okna, drzwi, kolor);
                Console.WriteLine("Zbudowano Dom");
                Console.WriteLine(dom.ToString());

            }

            if (decyzja == "x" || decyzja == "x")
                Environment.Exit(0);
        
            } while (decyzja !="x" || decyzja !="X");
           
            
            
            
        }
    }
}
