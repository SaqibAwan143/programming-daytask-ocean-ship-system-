using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.classes;
using programming_daytask_ocean_ship_system_.BL;


namespace programming_daytask_ocean_ship_system_.UI
{
    class AngleUI
    {
        public static void check_serial()
        {
            Angle anglX = new Angle();
            Angle anglY = new Angle();
            Console.WriteLine("Enter X degree :");
            anglX.Degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X minutes :");
            anglX.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter X Direction :");
            anglX.Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y degree :");
            anglY.Degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y minutes :");
            anglY.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Direction :");
            anglY.Direction = char.Parse(Console.ReadLine());
            ship shp = ShipDL.replace_name(anglX, anglY);
            if (shp == null)
            {
                Console.WriteLine("Ship does not exists");
            }
            else
            {
                Console.WriteLine(shp.Ship_number);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
