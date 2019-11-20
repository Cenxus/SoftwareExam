using System;

namespace exam_2
{
    public class Application
    {
        static void Main()
        {
            clothingFactory factory = null;
            Console.Write("Enter your clothing type: ");
            string choice = Console.ReadLine();

            switch(choice.ToLower())
            {
                case "Pants":
                    factory = new pantsFactory(20, 'M');
                    break;
                case "Sweater":
                    factory = new sweaterFactory(40, 'L');
                    break;
                case "Socks":
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
            Console.ReadKey();
        }
    }
}
