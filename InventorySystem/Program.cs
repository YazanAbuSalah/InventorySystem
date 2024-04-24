namespace InventorySystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name of Product");
            string name = Console.ReadLine();
            Console.WriteLine("enter price of Product");
            int  price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter quantity of Product");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product() { Name = name , Price = price , Quantity =quantity  };

            Inventory inventory = new Inventory();
            inventory.product.Add(p);
            inventory.inventoryProduct();

        }
    }
}
