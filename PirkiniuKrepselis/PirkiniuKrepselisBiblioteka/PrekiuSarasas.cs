using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirkiniuKrepselisBiblioteka
{
    public struct PrekiuSarasas
    {

        private int _customer;
        private List<Pirkinys> _pirkiniai;

        public PrekiuSarasas(int customeris)
        {
            this._customer = customeris;
            this._pirkiniai = new List<Pirkinys>();
        }

        public void Uzpildymas()
        {
            _pirkiniai.Add(new Pirkinys("TV", 1, 1100.99));
            _pirkiniai.Add(new Pirkinys("iPhone", 1, 880.99));
            _pirkiniai.Add(new Pirkinys("Watch", 1, 429.99));
            _pirkiniai.Add(new Pirkinys("airPods", 1, 249.99));
            _pirkiniai.Add(new Pirkinys("MagicPad", 2, 139.99));
        }
        public void VienosPrekesPridejimas(string pavadinimas1, int kiekis1, double kaina1)
        {
            _pirkiniai.Add(new Pirkinys(pavadinimas1, kiekis1, kaina1));
        }

        public bool ArSarasasTuscias()
        {
            bool isEmpty = !_pirkiniai.Any();
            if (isEmpty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveListeD(int p)
        {
            _pirkiniai.RemoveAt(p);
        }

        public int pirkiniuK
        {
            get
            {
                int kiekis = _pirkiniai.Count();
                return kiekis;
            }
            private set { }
        }

        public void sukeitimas(int NrSarese, int naujaReiksme)
        {
            _pirkiniai[NrSarese].kiekoPakeitimas(naujaReiksme);
        }

        public void Isvedimas()
        {
            double BendraKaina = 0;
            int nr = 0;
            foreach (var item in _pirkiniai)
            {
                Console.WriteLine("Eil. Nr: {3} - {0}, vnt: {1}, Kaina: {2}€", item.Pavadinimas, item.Kiekis, item.KainaViso, nr);
                BendraKaina = BendraKaina + item.KainaViso;
                nr++;
            }
            Console.WriteLine("Viso moketi: {0}€", BendraKaina);
        }
    }
}
