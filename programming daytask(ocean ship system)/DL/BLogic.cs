using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.classes;

namespace programming_daytask_ocean_ship_system_.BL
{
    class BLogic
    {
         public static List<ship> total_ships = new List<ship>();
        public static void addShipintoList(ship asd)
        {
         total_ships.Add(asd);
        }
        public static ship check_Ship(string check)
        {
            for (int i = 0; i < total_ships.Count; i++)
            {
                if(check == total_ships[i].Ship_number)
                {
                    return total_ships[i];
                }
            }
            return null;
        }
        public static ship replace_name(angle angX,angle angY)
        {
            for (int i = 0; i < total_ships.Count; i++)
            {
                if(angX.Degrees == total_ships[i].x.Degrees && angX.Minutes == total_ships[i].x.Minutes && angX.Direction == total_ships[i].x.Direction && angY.Degrees == total_ships[i].y.Degrees && angY.Minutes == total_ships[i].y.Minutes && angY.Direction == total_ships[i].y.Direction)
                {
                    return total_ships[i];
                }           
            }
            return null;
        }
    }
    
}
