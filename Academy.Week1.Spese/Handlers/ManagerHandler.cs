using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Handlers
{
    public class ManagerHandler : AbstractHandler
    {
        public override int HandleApprovazione(Spesa s)
        {
            if (s.Importo <= 400)
            {
                return 1; //1 livello manager
            }
            return base.HandleApprovazione(s);
        }
    }
}
