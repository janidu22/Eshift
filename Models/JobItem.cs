using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.Models
{
    public  class JobItem
    {
        public int ProductId { get; set; }
        public int? TransportUnitId { get; set; }
        public int Quantity { get; set; }
        public decimal? Weight { get; set; }
        public string? Notes { get; set; }
    }
}
