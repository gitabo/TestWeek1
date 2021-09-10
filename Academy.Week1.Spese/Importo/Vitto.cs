using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Importo
{
    public class Vitto : IImporto
    {
        public int imp { get; set; }
        public Vitto(int i)
        {
            imp = i;
        }
        public int CalcolaImporto()
        {
            return (int)(imp * 0.7);
        }
    }
}
