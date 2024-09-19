using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Rain : Precipitation
    {
        private double dropSize;

        public Rain(string location, bool active, double rateOfFall, double dropSize) : base(location, active, rateOfFall)
        {
            if(dropSize >= 0.02)
            {
                this.dropSize = dropSize;
            }
            else
            {
                this.dropSize = 0.02;
            } 
        }

        public double getDropSize()
        {
            return dropSize;
        }

        public void setDropSize(double dropSize)
        {
            if(dropSize >= 0.02)
            {
                this.dropSize = dropSize;
            }
            else Console.WriteLine("Invalid input, please try again");
        }

        public override string toString()
        {
            string size = "";
            if(dropSize < 0.066) size = "Small";
            else if(dropSize <= 0.112) size = "Medium";
            else size = "Large"; 

            return base.toString() + "Drop Size: " + dropSize + " (" + size + ")\n";
        }
    }   
}