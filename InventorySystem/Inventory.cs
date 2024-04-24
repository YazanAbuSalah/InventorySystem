using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Inventory
    {
        public List<Product> product { get; set; }

        public Inventory()
        {
            product = new List<Product>();
        }
  

        public void inventoryProduct() 
        {
            foreach (var item in product)
            {
                Console.WriteLine($"Product name : {item.Name}  ,  Product name : {item.Price}   ,   Product name : {item.Quantity} ");
            }
        }
    }
}
