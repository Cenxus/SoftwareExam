using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class Customer : User
    {
        private string _name;
        private readonly int _ID;
        private double _money;

        public Customer(string name, int ID, double money)
        {
            _name = name;
            _ID = ID;
            _money = money;
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

        public double money
        {
            get { return _money; }
            set { _money = value; }
        }

        public void Buy(string clothingType)
        {
            InventorySingleton inventory = InventorySingleton.GetInventorySingleton();
            List<clothes> wares = inventory.ClothesList(clothingType);
            for (int i = 0; i < wares.Count; i++)
            {
                if (wares[i].price < _money)
                {
                    _money = money - wares[i].price;
                    Console.WriteLine(name + " bought " + wares[i].clothingType.ToLower() + " " + inventory.ClothesList(clothingType).Count + " from the store.");
                    inventory.RemoveFromInventory(clothingType, i);
                    
                }
            }
        }
    }
}
