using System;
using System.Collections.Generic;
using System.Text;

namespace Publications2DExtended
{
    class StampBook : ISaleableItem
    {
        private int iQuantity;
        public int Quantity
        {
            get { return iQuantity; }
            set { iQuantity = value; }
        }

        private int iValue;
        public int Value
        {
            get { return iValue; }
            set { iValue = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = iQuantity * iValue; }
        }

        public StampBook(int iQuantity, int iValue, double price)
        {
            this.iQuantity = iQuantity;
            this.iValue = iValue;
            this.price = price;
        }

        public void SellCopy()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("            Stamp Book            ");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }

        public override String ToString()
        {
            return "Book of " + iQuantity + " X " + iValue + "p stamps";
        }
    }
}
