using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.BL;

namespace programming_daytask_ocean_ship_system_.classes
{
    
    class ship
    {
        private string ship_number;
        private Angle X;
        private Angle Y;
        public string Ship_number
        {
        get {return ship_number; }
        set { ship_number = value; }
        }
        public Angle x
        {
            get { return X; }
            set { X = value; }
        }
        public Angle y
        {
            get { return Y; }
            set { Y = value; }
        }
        public ship()
        {
        }
        public ship(string n,Angle x,Angle y)
        {
            ship_number = n;
            X = x;
            Y = y;
        }
        public void display()
        {
            Console.WriteLine("Ship is at "+X.Degrees+ "\u00b0"+X.Minutes+"'"+X.Direction +" and "+Y.Degrees+ "\u00b0"+Y.Minutes+"'"+Y.Direction);
        }
        public void value_change(Angle x,Angle y)
        {
            this.X = x;
            this.Y = y;
        }
    }

}
