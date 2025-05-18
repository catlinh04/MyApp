using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyApp.Application.Exceptions
{
     public class ForbiddenException : BaseException
    {
        public ForbiddenException(string message = "You do not have permission to access this resource.")
            : base(message, HttpStatusCode.Forbidden) { }
    }
}