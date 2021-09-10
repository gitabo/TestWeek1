using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual int HandleApprovazione(Spesa s)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.HandleApprovazione(s);
            }
            return 0;
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
