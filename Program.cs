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
            Menu SummerMenu = new Menu();
            SummerMenu.Name = "Summer Menu";
            MenuItem salmon = new MenuItem();
            salmon.title = "Salmoon";
            salmon.Description = " freash chease";
            salmon.Price = 123;

            SummerMenu.items.Add(salmon);
        }
    }
}
