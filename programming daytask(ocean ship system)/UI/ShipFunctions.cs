using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.classes;
using programming_daytask_ocean_ship_system_.BL;

namespace programming_daytask_ocean_ship_system_.UI
{
    class ShipFunctions
    {
        
        public static ship add_ship(List<ship> shep)

        {
            angle angleX = new angle();
            angle angleY = new angle();
            Console.WriteLine("Enter ship name :");
            string nameX = Console.ReadLine();
            Console.WriteLine("Enter degree :");
            angleX.Degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes :");
            angleX.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction :");
            angleX.Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter degree :");
            angleY.Degrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes :");
            angleY.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction :");
            angleY.Direction = char.Parse(Console.ReadLine());
            ship Ship = new ship(nameX, angleX, angleY);
            Console.ReadKey();
            Console.Clear();
            return Ship; 
        }
        public static void display_position(List<ship> name)
        {
            Console.WriteLine("Enter the name of the ship..:");
            string nam = Console.ReadLine();
            ship check = BLogic.check_Ship(nam);
            if(check != null)
            {
                for (int i = 0; i < name.Count; i++)
                {
                    name[i].display();
                }
            }
            else if(check == null)
            {
                Console.WriteLine("Ship does not exists");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void replace(List<ship> rename)
        {
            Console.WriteLine("Enter the ship name :");
            string name = Console.ReadLine();
            ship rep = BLogic.check_Ship(name);
            if(rep == null)
            {
                Console.WriteLine("Ship does not exists");
            }
            else if(rep != null)
            {
                for (int i = 0; i < rename.Count; i++)
                {
                    angle angleX = new angle();
                    angle angleY = new angle();
                    Console.WriteLine("Enter degree :");
                    angleX.Degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes :");
                    angleX.Minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Direction :");
                    angleX.Direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter degree :");
                    angleY.Degrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes :");
                    angleY.Minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Direction :");
                    angleY.Direction = char.Parse(Console.ReadLine());
                    rep.value_change(angleX, angleY);
                    Console.Clear();
                    Console.ReadKey();
                }
            }
        }
        public static void check_serial(List<ship> lis)
        {
            angle anglX = new angle();
            angle anglY = new angle();
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
            ship shp = BLogic.replace_name(anglX, anglY);
            if(shp == null)
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