using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}