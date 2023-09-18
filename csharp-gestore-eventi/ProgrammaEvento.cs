using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string titolo {  get; set; }
        public List<Evento> eventi { get; private set;}

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> EventiData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>;

            for(int i = 0; i < eventi.Count; i++)
            {
                if (eventi[i].Data.Date == data.Date)
                {
                    eventiInData.Add(eventi[i]);
                }
            }
            return eventiInData;
        }

        public static string StampaEventi(List<Evento> eventi)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Evento evento in eventi)
            {
                sb.AppendLine(evento.ToString());
            }
            return sb.ToString();
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }


    }
}
