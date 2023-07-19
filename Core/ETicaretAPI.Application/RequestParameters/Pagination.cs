using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.RequestParameters
{
    public record Pagination
    {
        public int size { get; set; } = 5;
        public int page { get; set; } = 0; 
    }
}
