using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace exam_2
{
    class Employee : User
    {
        private string _name;
        private readonly int _ID;
        Random _rand;
        private readonly object _lock = new object();

        public Employee(string name, int ID)
        {
            _name = name;
            _ID = ID;
            _rand = new Random();
        }

        public override string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override int ID
        {
            get { return _ID; }
        }

        protected override void Task()
        {
            Thread.Sleep(_rand.Next(50, 400));
            AddWare("pants", 199, 'M');
            AddWare("sweater", 399, 'L');
            AddWare("socks", 99, 'M');
        }

        public void AddWare(string clothingType, double price, char size)
        {
            lock (_lock)
            {
                clothingFactory factory = null;
                InventorySingleton inventory = InventorySingleton.GetInventorySingleton();

                switch (clothingType.ToLower())
                {
                    case "pants":
                        factory = new pantsFactory(price, size);
                        inventory.AddToInventory(factory.GetClothes());
                        Console.WriteLine(name + " added new " + clothingType + " " + inventory.ClothesList(clothingType).Count + " for sale.");
                        break;
                    case "sweater":
                        factory = new sweaterFactory(price, size);
                        inventory.AddToInventory(factory.GetClothes());
                        Console.WriteLine(name + " added new " + clothingType + " " + inventory.ClothesList(clothingType).Count + " for sale.");
                        break;
                    case "socks":
                        factory = new socksFactory(price, size);
                        inventory.AddToInventory(factory.GetClothes());
                        Console.WriteLine(name + " added new " + clothingType + " " + inventory.ClothesList(clothingType).Count + " for sale.");
                        break;
                    default:
                        Console.WriteLine("Nothing found");
                        break;
                }
            }
        }
    }
}
