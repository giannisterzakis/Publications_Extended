using System;
using System.Collections.Generic;
using System.Text;

namespace Publications2DExtended
{
    class Ticket : ISaleableItem
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string client;

        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public Ticket(string description, double price, string client)
        {
            this.description = description;
            this.price = price;
            this.client = client;
        }

        public void SellCopy()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("            TICKET VOUCHER            ");
            Console.WriteLine(this.ToString());
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return description + " for " + client;
        }
    }
}
