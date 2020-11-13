using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaccia
{
    class Brano
    {
        private string _titolo;
        private string[] _autori;
        private TimeSpan _durata;

        public Brano(string titolo, string[] autori, TimeSpan durata)
        {
            try
            {
                Titolo = titolo;
                Autore = autori;
                Durata = durata;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Titolo
        {
            get
            {
                return _titolo;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Titolo non valido");
                }
                _titolo = value.ToLower().Trim();
            }
        }

        public string[] Autore
        {
            get
            {
                return _autori;
            }
            private set
            {
                string[] autori = value;
                for (int i = 0; i < autori.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(autori[i]))
                    {
                        throw new Exception("Autore non valido");
                    }
                    autori[i].ToLower().Trim();
                }
                _autori = autori;
            }
        }

        public string StampaAutore
        {
            get
            {
                string listaAutori = "";
                for (int i = 0; i < Autore.Length; i++)
                {
                    if (i < Autore.Length - 1)
                    {
                        listaAutori += Autore[i] + ",";
                    }
                    else
                    {
                        listaAutori += Autore[i];
                    }
                }
                return listaAutori;
            }
            private set
            {

            }
        }

        public TimeSpan Durata
        {
            get
            {
                return _durata;
            }
            private set
            {
                try
                {
                    _durata = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public override string ToString()
        {
            if (Durata.TotalSeconds < 60)
            {
                return $"Titolo: {Titolo}, Autori: {StampaAutore}, Durata: {Durata.Seconds} secondi";
            }
            else if (Durata.TotalMinutes < 60)
            {
                return $"Titolo: {Titolo}, Autori: {StampaAutore}, Durata: {Durata.Minutes}:{Durata.Seconds} minuti";
            }
            return $"Titolo: {Titolo}, Autori: {StampaAutore}, Durata: {Durata.Hours}:{Durata.Minutes}:{Durata.Seconds} ore";
        }
    }
}
