using System;
using System.Collections.Generic;
using System.Text;

namespace Software_design_Exam
{
    enum clothingType { pants, sweater, socks };
    class clothFactory
    {
        private clothFactory() { }

        abstract class clothName
        {
            public abstract string pants { get; set; }
            public abstract string sweater { get; set; }
            public abstract string socks { get; set; }
        }

        public interface clothesFactoring
        {
            pants CreatePants();
            sweater CreateSweater();
            socks CreateSocks();
        }

        class clothesFactoring1
        {
            pants CreatePants()
            {
                return new pants();
            }

            sweater CreateSweater()
            {
                return new sweater();
            }

            socks CreateSocks()
            {
                return new socks();
            }
        }

        public static clothing Create(clothingType type, float[] parameters)
        {
            clothing clothing = null;

            switch (type)
            {
                case clothingType.pants:
                    clothing = new pants(parameters[0]);
                    break;
                case clothingType.sweater:
                    clothing = new sweater(parameters[0], parameters[1]);
                    break;
                case clothingType.socks:
                    clothing = new socks(parameters[0], parameters[1], parameters[2]);
                    break;
            }
            return clothing;
        }



    }
}
