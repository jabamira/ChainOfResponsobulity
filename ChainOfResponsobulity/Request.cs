using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsobulity
{
    public class Request
    {
        public string Type { get; }
        public string Content { get; }

        public Request(string type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}
