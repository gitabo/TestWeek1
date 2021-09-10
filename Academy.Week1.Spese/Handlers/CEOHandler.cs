using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Handlers
{
    public class CEOHandler: AbstractHandler
    {
        public override int HandleApprovazione(Spesa s)
        {
            if (s.Importo > 1000)
            {
                return 3; //3 livello CEO
            }
            return base.HandleApprovazione(s);
        }
    }
}
