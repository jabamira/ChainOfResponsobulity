using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobulity
{
    public class LoginHandler : Handler
    {
        protected override bool CanHandle(Request request) => request.Type == "Login";

        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine($"LoginHandler обработал запрос: {request.Content}");
        }
    }
}
