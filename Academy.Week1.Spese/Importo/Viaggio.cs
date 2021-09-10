using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Importo
{
    public class Viaggio : IImporto
    {
        public int imp { get; set; }

        public Viaggio(int i)
        {
            imp = i;
        }
        public int CalcolaImporto()
        {
            return imp + 50;
        }
    }
}
