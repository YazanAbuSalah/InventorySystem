using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Utilities
    {
        Inventory inventory = new Inventory();

        public void ShowMainMenu()
        {

            Console.WriteLine("********************");
            Console.WriteLine("* Select an action *");
            Console.WriteLine("********************");

            Console.WriteLine("1: Add product");
            Console.WriteLine("2: View products");
            Console.WriteLine("3: Edit product");
            Console.WriteLine("4: Delete a product");


            Console.Write("Your selection: ");

            string? userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    showProducts();
                    break;
                case "3":
                    editProduct();
                    break;
                case "4":
                    DeleteProduct();
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }

        public  void AddProduct() 
        {
            Console.WriteLine("enter name of Product");
            string name = Console.ReadLine();
            Console.WriteLine("enter price of Product");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter quantity of Product");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product() { Name = name, Price = price, Quantity = quantity };

            inventory.products.Add(p);
            ShowMainMenu();
        }

        public void showProducts()
        {
            inventory.inventoryProduct();
            ShowMainMenu();
        }

        public void editProduct()
        {

            Console.WriteLine("enter name of product ");

            string nameOfProduct = Console.ReadLine();

            inventory.UpdaupdateProduct(nameOfProduct);

            inventory.inventoryProduct();
            ShowMainMenu();
        }


        public void DeleteProduct()
        {
            Console.WriteLine("enter the name of product");
            string name = Console.ReadLine();

            inventory.deleteProduct(name);
            ShowMainMenu();
        }
    }
}
