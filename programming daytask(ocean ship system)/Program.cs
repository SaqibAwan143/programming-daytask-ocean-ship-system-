using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.classes;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.BL;

namespace programming_daytask_ocean_ship_system_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                char option = MENU_UI_.main_menu();
                if(option == '1')
                {
                    BLogic.addShipintoList( ShipFunctions.add_ship(BLogic.total_ships));
                }
                else if(option == '2')
                {
                    ShipFunctions.display_position(BLogic.total_ships);
                }
                else if (option == '3')
                {
                    ShipFunctions.check_serial(BLogic.total_ships);
                }
                else if (option == '4')
                {
                    ShipFunctions.replace(BLogic.total_ships);
                }
                else if (option == '5')
                {
                    break;
                }
            }
        }
    }
}
