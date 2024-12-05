using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobulity
{
    public class DefaultHandler : Handler
    {
        protected override bool CanHandle(Request request) => true;

        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine($"DefaultHandler обработал запрос по умолчанию: {request.Content}");
        }
    }
}
