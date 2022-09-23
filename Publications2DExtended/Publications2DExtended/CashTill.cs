using System;
using System.Collections.Generic;
using System.Text;

namespace Publications2DExtended
{
    class CashTill
    {
        private double runningTotal;

        public CashTill()
        {
            runningTotal = 0;
        }

        public void SellItem(ISaleableItem selb)
        {
            String msg;

            runningTotal = runningTotal + selb.Price;
            selb.SellCopy();

            msg = "Sold " + selb.ToString() + " @ " + selb.Price +
                  "\nSubtotal = " + runningTotal;
            Console.WriteLine(msg);
        }

        public void ShowTotal()
        {
            Console.WriteLine("GRAND TOTAL: " + runningTotal);
            runningTotal = 0;
        }

        public void SaleType(ISaleableItem selb)
        {
            if (selb is Publication)
            {
                Console.WriteLine(selb.ToString() + " is a Publication");
            }
            else if (selb is Ticket)
            {
                Console.WriteLine(selb.ToString() + " is a Ticket");
            }
            else if (selb is StampBook)
            {
                Console.WriteLine(selb.ToString() + " is a Stamp Book");
            }
            else
            {
                Console.WriteLine(selb.ToString() + " is an unknown sale type");
            }
        }
    }
}
