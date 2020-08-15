using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMicroService.ViewModel
{
    public class OrderViewModel
    {
        public long OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
