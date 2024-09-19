using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class Precipitation : WeatherEvent
    {
        private double rateOfFall;

        public Precipitation(string location, bool active, double rateOfFall) : base(location, active)
        {
            if(rateOfFall >= 0)
            {
                this.rateOfFall = rateOfFall;
            }
            else
            {
                this.rateOfFall = 0;
            } 
        }

        public double getRateOfFall()
        {
            return rateOfFall;
        }

        public void setRateOfFall(double rateOfFall)
        {
            if(rateOfFall >= 0)
            {
                this.rateOfFall = rateOfFall;
            }
            else Console.WriteLine("Invalid input, please try again");
        }

        public override string toString()
        {
            string heaviness = "";
            if(rateOfFall < 0.5) heaviness = "Light";
            else if(rateOfFall <= 1.5) heaviness = "Medium";
            else heaviness = "Heavy"; 

            return base.toString() + "Rate Of Fall: " + rateOfFall + " in/h (" + heaviness + ")\n";
        }
    }   
}