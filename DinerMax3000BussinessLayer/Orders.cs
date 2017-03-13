using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMAX_3000_Console
{   // 11 how to interate the objects 
    public class Orders
    {
        public List<MenuItem> items = new List<MenuItem>();
        //14 properties
        public double Total
        { get
            {
                double caclculateTotal = 0;
                foreach (MenuItem item in items)
                {
                    caclculateTotal += item.Price;
                }
                return caclculateTotal;
            }
                }

    }
}
