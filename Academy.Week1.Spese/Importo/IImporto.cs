using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Importo
{
    public interface IImporto
    {
        public int imp {get; set;}
        public int CalcolaImporto();  
    }
}
