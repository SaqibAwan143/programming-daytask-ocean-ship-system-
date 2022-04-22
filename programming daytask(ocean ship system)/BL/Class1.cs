﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programming_daytask_ocean_ship_system_.UI;
using programming_daytask_ocean_ship_system_.BL;


namespace programming_daytask_ocean_ship_system_.classes
{
    class angle
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
    class ship
    {
        private string ship_number;
        private angle X;
        private angle Y;
        public string Ship_number
        {
        get {return ship_number; }
        set { ship_number = value; }
        }
        public angle x
        {
            get { return X; }
            set { X = value; }
        }
        public angle y
        {
            get { return Y; }
            set { Y = value; }
        }
        public ship()
        {
        }
        public ship(string n,angle x,angle y)
        {
            ship_number = n;
            X = x;
            Y = y;
        }
        public void display()
        {
            Console.WriteLine("Ship is at "+X.Degrees+ "\u00b0"+X.Minutes+"'"+X.Direction +" and "+Y.Degrees+ "\u00b0"+Y.Minutes+"'"+Y.Direction);
        }
        public void value_change(angle x,angle y)
        {
            this.X = x;
            this.Y = y;
        }
    }

}
