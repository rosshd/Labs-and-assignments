using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Snow : Precipitation
    {
        private double temperature;

        public Snow(string location, bool active, double rateOfFall, double temperature) : base(location, active, rateOfFall)
        {
            if(temperature <= -459.67)
            {
                this.temperature = -459.67;
            }
            else if(temperature >= 32)
            {
                this.temperature = 32;
            } 
            else this.temperature = temperature;
        }

        public double getTemperature()
        {
            return temperature;
        }

        public void setTemperature(double temperature)
        {
            if(temperature <= -459.67)
            {
                this.temperature = -459.67;
            }
            else if(temperature >= 32)
            {
                this.temperature = 32;
            } 
            else this.temperature = temperature;
        }

        public override string toString()
        {
            return base.toString() + "Temperature: " + temperature + " F\n";
        }
    }   
}