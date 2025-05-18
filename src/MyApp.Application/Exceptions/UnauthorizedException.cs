using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyApp.Application.Exceptions
{
     public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message = "Authentication is required to access this resource.")
            : base(message, HttpStatusCode.Unauthorized) { }
    }
}