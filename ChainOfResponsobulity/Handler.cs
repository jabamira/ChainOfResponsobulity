using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobulity
{
    public abstract class Handler
    {
        protected Handler? NextHandler { get; private set; }

        public Handler SetNext(Handler nextHandler)
        {
            NextHandler = nextHandler;
            return nextHandler;
        }

        public void HandleRequest(Request request)
        {
            if (CanHandle(request))
            {
                ProcessRequest(request);
            }
            else
            {
                NextHandler?.HandleRequest(request);
            }
        }

        protected abstract bool CanHandle(Request request);

        protected abstract void ProcessRequest(Request request);
    }
}
