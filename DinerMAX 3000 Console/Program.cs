using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMAX_3000.Bussiness;

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

            Console.WriteLine("1 The Total price is :{0}", HungeryMenOrder.Total);

            // 13 or we can use foreach loop also

            foreach (MenuItem item in outsiders.items)
            {
                HungeryMenOrder.items.Add(item);
            }
            // 15 
            Console.WriteLine("2 The Total price is :{0}",HungeryMenOrder.Total);
            Console.ReadLine();
           // 16  we cannot assign the custom value to toatl which is due to it sproperties behaviour  Console.WriteLine(HungeryMenOrder.Total=90);

            // 18 now test our prperty of negative avlue but program crases so to avoid impliment try catch finnally.

            try
            {
               outsiders.AddMenuItem("free drink", -12, "testing allowd or not");
            }
            catch(Exception thowException)
            {
                Console.WriteLine(thowException.Message);
            }

        }
    }
}
