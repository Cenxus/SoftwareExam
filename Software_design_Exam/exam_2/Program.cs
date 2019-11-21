using System;
using System.Collections.Generic;
using System.Threading;

namespace exam_2
{
    public class Application
    {
        
        static void Main()
        {
            Employee _store = new Employee("Store", 01);
            List<Customer> _customers = new List<Customer>() {new Customer("Pål", 02), new Customer("Per", 03), new Customer("Espen", 03), };
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();

            _store.Start();
            foreach(var customer in _customers)
            {
                customer.Start();
            }

            Thread.Sleep(3000);

            foreach (var customer in _customers)
            {
                customer.Stop();
            }
            _store.Stop();
            /*
            clothingFactory factory = null;
            Console.Write("Enter your clothing type: ");
            string choice = Console.ReadLine();

            switch(choice.ToLower())
            {
                case "pants":
                    factory = new pantsFactory(20, 'M');
                    break;
                case "weater":
                    factory = new sweaterFactory(40, 'L');
                    break;
                case "socks":
                    factory = new socksFactory(16, 'S');
                    break;
                default:
                    Console.WriteLine("Nothing found");
                    break;
            }

            clothes clothes = factory.GetClothes();
            Console.WriteLine("\n The details of your choice are written bellow: \n");
            Console.WriteLine("Clothing type: {0}\nPrice: {1}\nSize: {2}", 
                clothes.clothingType, clothes.price, clothes.size);
            Console.ReadKey();*/
        }
    }
}
