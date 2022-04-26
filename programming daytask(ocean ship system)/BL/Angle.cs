using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.classes;

namespace programming_daytask_ocean_ship_system_.BL
{
    class Angle
    {
       
        private int degrees;
        private float minutes;
        private char direction;
        public int Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }
            
        public float Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public char Direction
        {
            get { return direction; }
            set { direction = value; }
        }
    }
}
