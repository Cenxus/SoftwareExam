using System;
using System.Collections.Generic;
using System.Text;

namespace Software_design_Exam
{
    public interface clothes
    {
        void buy();
    }

    internal class pants : clothes
    {
        public void buy()
        {
            Console.WriteLine();
        }
    }

    internal class sweater : clothes
    {
        public void buy()
        {
            Console.WriteLine();
        }
    }

    internal class socks : clothes
    {
        public void buy()
        {
            Console.WriteLine();
        }
    }

    class program
    {

    }
}
