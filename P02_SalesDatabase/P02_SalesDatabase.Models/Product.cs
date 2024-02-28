using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.P02_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }

        public List<Sale> sales { get; set; }
    }
}
