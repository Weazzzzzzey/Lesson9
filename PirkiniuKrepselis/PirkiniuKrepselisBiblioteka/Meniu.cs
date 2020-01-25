using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirkiniuKrepselisBiblioteka
{
    public class Meniu
    {
        PrekiuSarasas s1 = new PrekiuSarasas(1);
        public void pradzia()
        {
            Console.WriteLine("Ka norite atlikti? - 1 prideti prekia, 2 perziureti sarasa. Istrinti preke? - 3 arba keisti prekes kieki - 4");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                string pavadinimas = "Pele";
                int kiekis = 2;
                double vntK = 20.99;

                s1.VienosPrekesPridejimas(pavadinimas, kiekis, vntK);
                Console.WriteLine("Preke prideta.");
                testiDarba();
            }
            else if (pasirinkimas == 2)
            {
                sarasoPatikra();
                testiDarba();
            }
            else if (pasirinkimas == 3)
            {
                nueitiItrinima();
                testiDarba();
            }
            else if (pasirinkimas == 4)
            {
                koreguotiKieki();
                testiDarba();
            }
        }
        
        public void nueitiItrinima()
        {
            if (sarasoPatikra() == true)
            {
                Console.WriteLine("");
            }
            else
            {
                IstrintiIsSarasoNumeri();
            }
        }
        
        public void IstrintiIsSarasoNumeri()
        {
            s1.Isvedimas();
            Console.WriteLine("Iveskite kuria preke norite istrinti?");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (s1.pirkiniuK < pasirinkimas)
            {
                Console.WriteLine("Prekiu sarase tiek nera.");
            }
            else
            {
                s1.RemoveListeD(pasirinkimas);
                testiDarba();
            }
        }

        public bool sarasoPatikra()
        {
            if (s1.ArSarasasTuscias() == true)
            {
                Console.WriteLine("Saras vis dar tuscias!");
                return true;
            }
            else
            {
                s1.Isvedimas();
                return false;
            }
        }

        public void koreguotiKieki()
        {

            if (sarasoPatikra() == true)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Kuria prekia koreguoti? ivesti nr. is saraso, taip pat nauja kieki");
                int pasirinkimas = Convert.ToInt32(Console.ReadLine());
                int kk = Convert.ToInt32(Console.ReadLine());
                s1.sukeitimas(pasirinkimas, kk);
            }
            testiDarba();

        }

        public void testiDarba()
        {
            Console.WriteLine("Testi darba? - spauskite 1, baigti - 2");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                pradzia();
            }
            else if (pasirinkimas == 2)
            {
                Console.WriteLine("Geros dienos!");
            }
        }
    }
}
