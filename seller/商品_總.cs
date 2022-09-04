using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seller
{
    public class 商品_總
    {
        public int MemberID
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public decimal AdFee
        {
            get;
            set;
        }

        public int SmallTypeID
        {
            get;
            set;
        }

        public int RegionID
        {
            get;
            set;
        }

        public int ShipperID
        {
            get;
            set;
        }
    }
}
