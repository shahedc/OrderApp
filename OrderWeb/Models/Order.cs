using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWeb.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDetails { get; set; }

        public Customer Customer { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}
