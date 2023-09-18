using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            Titolo = titolo;
            Data = data;
            this.capienzaMax = capienzaMassima;
            this.postiPrenotati = 0;
        }

        public string Titolo
        {
            get
            {
              return titolo;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Il titolo non può essere vuoto");
                }
                titolo = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("La data non può essere già passata");
                }
                data = value;
            }
        }

        public int CapienzaMassima { 
            get
            {
                return capienzaMax;
            }
            
        }

        public int PostiPrenotati
        {
            get
            {
                return postiPrenotati;
            }
        }

        public void PrenotaPosti(int postiDaPrenotare)
        {
            if (data < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }

            if (postiDaPrenotare > capienzaMax - postiPrenotati)
            {
                throw new Exception("Non ci sono abbastanza posti disponibili");
            }

            postiPrenotati += postiDaPrenotare;
            Console.WriteLine($"Numero di posti prenotati: {postiPrenotati}");
            Console.WriteLine($"Numero di posti disponibili: {capienzaMax - postiPrenotati}");
        }

        public void DisdiciPosti(int postiDaDisdire)
        {
            if (data < DateTime.Now)
            {
                throw new Exception("L'evento è già passato");
            }

            if (postiDaDisdire > postiPrenotati)
            {
                throw new Exception("Non ci sono abbastanza posti prenotati da disdire");
            }

            postiPrenotati -= postiDaDisdire;
        }

        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} – {Titolo}";
        }
    }

}