using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Domain.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException(string message) : base(message) { }
    }
}