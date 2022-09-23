using System;
using System.Collections.Generic;
using System.Text;

namespace Publications2DExtended
{
    interface ISaleableItem
    {
        double Price
        {
            get;
        }
        void SellCopy();
    }
}
