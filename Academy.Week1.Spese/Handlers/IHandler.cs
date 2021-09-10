using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        int HandleApprovazione(Spesa s);
    }
}
