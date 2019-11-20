using System;
using System.Collections.Generic;
using System.Text;

namespace Software_design_Exam
{
    public abstract class clothing
    {
        private string name;
        private int id;
        private string material;
        private double price;
        private char size;

        protected clothing (string material, double price, char size)
        {
            this.name = name;
            this.id = id;
            this.material = material;
            this.price = price;
            this.size = size;
        }
    }
}
