using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Handlers
{
        public class OperationalHandler : AbstractHandler
        {
            public override int HandleApprovazione(Spesa s)
            {
                if (s.Importo > 400)
                {
                    return 2; //2 livello operational manager
                }
                return base.HandleApprovazione(s);
            }
        }
    
}
