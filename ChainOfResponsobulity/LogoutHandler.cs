using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobulity
{
    public class LogoutHandler : Handler
    {
        protected override bool CanHandle(Request request) => request.Type == "Logout";

        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine($"LogoutHandler обработал запрос: {request.Content}");
        }
    }
}
