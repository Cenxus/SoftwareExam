﻿using System;
using System.Collections.Generic;
using System.Text;

namespace exam_2
{
    class pants : clothes
    {
        private readonly string _clothingType;
        private double _price;
        private char _size;

        public pants (double price, char size)
        {
            _clothingType = "Pants";
            _price = price;
            _size = size;
        }

        public override string clothingType
        {
            get { return _clothingType; }
        }

        public override double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override char size
        {
            get { return _size; }
            set { _size = value; }
        }
    }

}
