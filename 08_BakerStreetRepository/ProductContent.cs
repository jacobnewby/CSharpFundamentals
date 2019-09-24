using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_BakerStreetRepository;

namespace _08_BakerStreetRepository
{
    public enum BakeType { Bread = 1, Cake, Pastery, Pies }
    public class ProductContent
    {
        
        public ProductContent(string productName, string customerName, int orderBatchSize, BakeType type)
        {
            ProductName = productName;
            CustomerName = customerName;
            OrderBatchSize = orderBatchSize;
            Type = type;

        }

        public ProductContent(string productName, string customerName, int orderBatchSize, decimal orderCost, BakeType type)
        {
            ProductName = productName;
            CustomerName = customerName;
            OrderBatchSize = orderBatchSize;
            Type = type;
            OrderCost = orderCost;
        }

        public ProductContent()
        {

        }

        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int OrderBatchSize { get; set; }
        public decimal OrderCost { get; set; }
        public BakeType Type { get; set; }
    }
}
