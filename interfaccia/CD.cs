using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaccia
{
    class CD
    {
        private List<Brano> _listaBrani;
        public CD(string titolo, string autore, List<Brano> listaBrani)
        {
            Titolo = titolo;
            Autore = autore;
            _listaBrani = listaBrani;
        }

        public List<Brano> Brani
        {
            get;
            set;
        }

        public string Titolo
        {
            get;
            set;
        }

        public string Autore
        {
            get;
            set;
        }

        public TimeSpan Durata()
        {
            TimeSpan durata = new TimeSpan();
            foreach (Brano br in _listaBrani)
            {
                durata = durata + br.Durata;
            }
            return durata;
        }

        public override string ToString()
        {
            return Titolo + ", " + Autore + ", " + Durata();
        }
    }
}
