using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMAX_3000_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu SummerMenu = new Menu();  // Step 8 
            FoodMenu SummerMenu = new FoodMenu();
            SummerMenu.Name = "Summer Menu";
            SummerMenu.AddMenuItem("Salmoon", 231, "freash chease");   // Step 6 add more and more items
            SummerMenu.AddMenuItem("Sharbad", 431, "Could Drink");
            SummerMenu.AddMenuItem("Papaya", 531, "Juice");
            SummerMenu.AddMenuItem("Mango", 2731, "Pana");
            SummerMenu.HospitalDirections = "Asking for DR. john";  // 8
            // 10
            DrinkMenu outsiders = new DrinkMenu();
            outsiders.Desclamer = "Do not drink and code";
            outsiders.AddMenuItem("RUm", 234, "It's cruel");
            outsiders.AddMenuItem("MD", 456, "To hard to eat");
            outsiders.AddMenuItem("Classic", 567, "for everyone");
            // Step 4
            //MenuItem salmon = new MenuItem();
            //salmon.title = "Salmoon";
            //salmon.Description = " freash chease";
            //salmon.Price = 123;
            //SummerMenu.items.Add(salmon);


            //12 instance of order object

            Orders HungeryMenOrder = new Orders();
            for (int x = 0; x < SummerMenu.items.Count-1; x++)
            {
                MenuItem CurrentItems = SummerMenu.items[x];
                HungeryMenOrder.items.Add(CurrentItems); 
            }

            // 13 or we can use foreach loop also

            foreach (MenuItem item in outsiders.items)
            {
                HungeryMenOrder.items.Add(item);
            }

        }
    }
}
