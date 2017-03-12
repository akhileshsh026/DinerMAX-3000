using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMAX_3000_Console
{
   public class Menu
    {
        // 3 so initilizing the object of list. so that as soon as the obj is created 

        public Menu ()
        {
            items = new List<MenuItem>();
        }


        // menu sholud have a name 

        public String Name;

        // contains items list can hold an item of any item 

        public List<MenuItem> items;

        // to use items we need to initilize the items of list as soon as the menu object created 

    }
}
