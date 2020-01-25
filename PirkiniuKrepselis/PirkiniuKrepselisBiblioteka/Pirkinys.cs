using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirkiniuKrepselisBiblioteka
{
    public struct Pirkinys
    {
        private string _prekesPavadinimas;
        private int _kiekis;
        private double _vntKaina;
        private double _kainaViso;

        public Pirkinys(string pavadinimas, int kiekis, double vntKaina)
        {
            this._prekesPavadinimas = pavadinimas;
            this._kiekis = kiekis;
            this._vntKaina = vntKaina;
            this._kainaViso = 0;
        }

        public double KainaViso
        {
            get
            {
                _kainaViso = _kiekis * _vntKaina;
                return _kainaViso;
            }
            private set { }
        }

        public string Pavadinimas
        {
            get { return _prekesPavadinimas; }
            private set { }
        }

        public int Kiekis
        {
            get { return _kiekis; }
            set { _kiekis = value; }
        }

        public void kiekoPakeitimas(int kk)
        {
            Kiekis = kk;
        }
    }
}
