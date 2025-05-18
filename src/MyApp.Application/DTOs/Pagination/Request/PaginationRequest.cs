using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Pagination.Request
{
    public class PaginationRequest
    {
        public int Limit { get; set; }
        public int Offset { get; set; }

    }
}