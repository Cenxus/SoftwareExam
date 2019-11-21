using System;

namespace exam_2
{
    public class Application
    {
        
        static void Main()
        {
            Employee _store = new Employee("Per", 01);
            Customer _customer1 = new Customer("Pål", 02, 500);
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
            _store.AddWare("pants", 99.99, 'm');
            _store.AddWare("pants", 199.99, 'l');
            _store.AddWare("pants", 99.99, 's');
            _customer1.Buy("pants");



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
