using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallAuswahl
{
    internal class Land
    {
        public string Name { get; }
        public string Hauptstadt { get; }
        public string Bilddatei { get; }
        
        public Land(string name,string hauptstadt,string bilddatei)
        {
            Name= name;
            Hauptstadt = hauptstadt;
            Bilddatei=bilddatei;
        }
    }
}
