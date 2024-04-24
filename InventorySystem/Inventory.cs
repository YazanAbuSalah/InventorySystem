using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Inventory
    {
        public List<Product> products { get; set; }

        public Inventory()
        {
            products = new List<Product>();
        }

  

        public void inventoryProduct() 
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product name : {product.Name}  ,  Product name : {product.Price}   ,   Product name : {product.Quantity} ");
            }
        }

        public void UpdaupdateProduct(string  nameOfProduct ) 
        {
            foreach (var product in products)
            {
                if (product.Name == nameOfProduct)
                {
                    Console.WriteLine("Enter the new name ");
                    string newName = Console.ReadLine();
                    product.Name = newName;

                    Console.WriteLine("nter the new Price");
                    int newPrice = int.Parse(Console.ReadLine());
                    product.Price = newPrice;

                    Console.WriteLine("Enter the new Quantity");
                    int newQuantity = int.Parse(Console.ReadLine());
                    product.Quantity = newQuantity;





                }
                else
                {
                    Console.WriteLine("This product does not exist");
                }



            }

        }


        public void deleteProduct(string name)
        {
            Product productToRemove = null;
            foreach(var product in products)
            {
                if (product.Name == name)
                {
                    productToRemove = product;
                }
            }
            if(productToRemove != null)
            {
                products.Remove(productToRemove);
            }
            
        }




    }
}
