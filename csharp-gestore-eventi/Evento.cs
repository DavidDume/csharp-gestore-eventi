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
        public string titolo { get; set; }
        public DateTime Data { get; set; }
        public int CapienzaMax { get; }
        public int PostiPrenotati { get; }

        public String Titolo
        {
            get { return titolo; }
            set
            {
                if(titolo == "")
                {
                    return;
                }
                titolo = value;
            }
        

    }
}
