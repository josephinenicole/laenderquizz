using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaenderspielApp
{
    public class HighscoreEintrag
    {
        public long Id { get; }
        public string SpielerName { get; }
        public int Punktzahl { get; }
        public DateTime Datum { get; }

        public HighscoreEintrag(long id,string spielerName, int punktzahl, DateTime datum)
        {
            Id = id;
            SpielerName = spielerName;
            Punktzahl = punktzahl;
            Datum = datum;
        }
    }
}
