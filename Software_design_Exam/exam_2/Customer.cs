using System;
using System.Collections.Generic;

namespace exam_2
{
    class Customer : User
    {
        private string _name;
        private readonly int _ID;
        private readonly object _lock = new object();

        public Customer(string name, int ID)
        {
            _name = name;
            _ID = ID;
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
            while(_running)
            {
                Browse();
            }
        }

        public void Browse()
        {
            lock (_lock)
            {
                InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
                bool bought = false;
                Random random = new Random();
                var list = new List<string> { "pants", "sweater", "socks" };
                int index = random.Next(list.Count);
                while (bought != true)
                {
                    List<clothes> wares = inventory.ClothesList(list[index]);
                    for (int i = 0; i < wares.Count; i++)
                    {
                        int randomNumber = random.Next(0, 12);
                        if (randomNumber == 10)
                        {

                            Console.WriteLine(name + " bought a size " + wares[i].size + " " + wares[i].clothingType + " for " + wares[i].price + ".");
                            inventory.RemoveFromInventory(list[index], i);
                            bought = true;
                        }
                        else if (i == wares.Count - 1)
                        {
                            i = 0;
                        }
                    }
                }
            }
        }
    }
}
