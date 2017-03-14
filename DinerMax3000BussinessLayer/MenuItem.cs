using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMAX_3000.Bussiness
{
    public class MenuItem
    {
        public String title;
        public double Price;
        public String Description;

        // 17 here problem with price , it will accept the price in -ive so for that set the properties.

        private double _price
        {
            get
            { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
                else
                {
                    throw new ApplicationException(" U Cannot  have a free or Negative value ");
                }
            }
        }
    }

}
