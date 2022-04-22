using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.classes;

namespace programming_daytask_ocean_ship_system_.UI
{
    class MENU_UI_
    {
        public static void header()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*      Ship Management System      *");
            Console.WriteLine("************************************");
        }
        public static char main_menu()
        {
            header();
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship position");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Your Option...");
            char op = char.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();
            return op;

        }
    }
}
