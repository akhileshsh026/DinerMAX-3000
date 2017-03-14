using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Bussiness.DsDinerMAx3000TableAdapters;

namespace DinerMAX_3000.Bussiness
{
   public class Menu
    {
        // 3 so initilizing the object of list. so that as soon as the obj is created 

        public Menu ()
        {
            items = new List<MenuItem>();
        }

        //27 genrating after creating the dataaset

        public List<Menu>  GetAllMenus()
        {
            MenuTableAdapter tblMenu = new MenuTableAdapter();
            MenuItemTableAdapter tblMenuItem = new MenuItemTableAdapter();
            var dtMenu = tblMenu.GetData();

            List<Menu> allMenus = new List<Menu>();
            foreach (var MenuRow in dtMenu.Rows)
            {
                Menu CurrentMenu = new Menu();
                CurrentMenu.Name= MenuRow.
            }
            { // अधुरा है

            }
        }



        // 4 modified in the main f(x) creating the obj .

            //5 

            public void AddMenuItem(String Title , double Price , String Description)
        {
            MenuItem item = new MenuItem();
            item.title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
        }

        //1 menu sholud have a name 

        public String Name;

        //2 contains items list can hold an item of any item 

        public List<MenuItem> items;

        //3 to use items we need to initilize the items of list as soon as the menu object created 

    }
}
