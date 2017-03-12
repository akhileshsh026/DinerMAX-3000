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

        // 4 modified in the main f(x) creating the obj .

            //5 

            public void AddMenuItem(String Title , double Price , String Description)
        {
            MenuItem item = new MenuItem();
            item.title = "Title ";
            item.Description = "Description";
            item.Price = 234.56;
            items.Add(item);
        }

        //1 menu sholud have a name 

        public String Name;

        //2 contains items list can hold an item of any item 

        public List<MenuItem> items;

        //3 to use items we need to initilize the items of list as soon as the menu object created 

    }
}
