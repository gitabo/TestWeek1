using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Importo
{
    public class Alloggio : IImporto
    {
        public int imp { get; set; }

        public Alloggio(int i)
        {
            imp = i;
        }
        public int CalcolaImporto()
        {
            return imp;
        }
    }
}
