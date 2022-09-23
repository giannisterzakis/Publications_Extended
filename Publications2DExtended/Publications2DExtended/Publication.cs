using System;
using System.Collections.Generic;
using System.Text;

namespace Publications2DExtended
{
    abstract class Publication : ISaleableItem
    {
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int copies;

        public int Copies
        {
            get { return copies; }
            set { copies = value; }
        }

        public Publication(String title, double price, int copies)
        {
            this.title = title;
            this.price = price;
            this.copies = copies;
        }

        /**
         * Sell one copy
         */
        public void SellCopy()
        {
            copies--;
        }

        public override String ToString()
        {
            return title;
        }
    }

    class Book : Publication
    {
        private String author;

        public String Author
        {
            get { return author; }
            set { author = value; }
        }

        public Book(String title, double price, int copies, String author) : base(title, price, copies)
        {
            this.author = author;
        }

        public virtual void OrderCopies(int copies)
        {
            Copies = Copies + copies;
        }

        public override String ToString()
        {
            return base.ToString() + " by " + author;
        }
    }

    class Magazine : Publication
    {
        private int orderQty;

        public int OrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        private String currIssue;

        public String CurrIssue
        {
            get { return currIssue; }
            set { currIssue = value; }
        }

        public Magazine(String title, double price, int copies, int orderQty,
                String currIssue)
            : base(title, price, copies)
        {
            this.orderQty = orderQty;
            this.currIssue = currIssue;
        }

        /**
         * Adjust quantity
         */
        public void AdjustQty(int qty)
        {
            orderQty = qty;
        }

        /**
         * Receive new issue
         */
        public virtual void RecvNewIssue(String newIssue)
        {
            Copies = orderQty;
            currIssue = newIssue;
        }

        public override String ToString()
        {
            return base.ToString() + " (" + currIssue + ")";
        }
    }

    class DiscMag : Magazine
    {
        public DiscMag(String title, double price, int copies, int orderQty,
                String currIssue)
            : base(title, price, copies, orderQty, currIssue)
        {

        }
        /**
         * Receive new issue
         */
        public override void RecvNewIssue(String newIssue)
        {
            base.RecvNewIssue(newIssue);
            Console.WriteLine("Check discs attached to this magazine");
        }
    }

    class BulkBook : Book
    {
        const int BATCH_SIZE = 100;

        public BulkBook(String title, double price, int copies, String author)
            : base(title, price, copies, author)
        {
        }

        public void BulkOrder()
        {
            Copies = Copies + BATCH_SIZE;
        }

        public override void OrderCopies(int copies)
        {
            // check if this is a legitimate batch size
            if ((copies % BATCH_SIZE) == 0)
            {
                // yes - acceptable batch size
                base.OrderCopies(copies);
            }
            else
            {
                // no - reject order
                Console.WriteLine("ERROR - order must be a multiple of "
                                  + BATCH_SIZE);
            }
        }
    }
}
