using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class Obscuration : WeatherEvent
    {
        private int visibility;

        public Obscuration(string location, bool active, int visibility) : base(location, active)
        {
            if(visibility >= 0)
            {
                this.visibility = visibility;
            }
            else
            {
                this.visibility = 0;
            } 
        }

        public int getVisibility()
        {
            return visibility;
        }

        public virtual void setVisibility(int visibility)
        {
            if(visibility >= 0)
            {
                this.visibility = visibility;
            }
            else Console.WriteLine("Invalid input, please try again");
        }

        public override string toString()
        {
            if(visibility >= 56)
            {
                return base.toString() + "Visibility: Normal\n";
            }
            else return base.toString() + "Visibility: " + visibility + "/8 mi\n";
        }
    }   
}