using Academy.Week1.Spese.Importo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese
{
    public class ImportoFactory
    {
        public Spesa s;
        public ImportoFactory(Spesa sp)
        {
            s = sp;
        }
        public IImporto GetCategory(){
            if (s.Categoria.Equals("Viaggio"))
                return new Viaggio(s.Importo);
            else if (s.Categoria.Equals("Alloggio"))
                return new Alloggio(s.Importo);
            else if (s.Categoria.Equals("Vitto"))
                return new Alloggio(s.Importo);
            else
                return new Altro(s.Importo);
        }
        
    }
}
