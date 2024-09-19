using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class WeatherEvent
    {
        private string location;
        private static int nextID = 0;
        private int id;
        private bool active;

        public WeatherEvent(string location, bool active)
        {
            this.id = nextID;
            nextID++;
            this.location = location;
            this.active = active;
        }

        public string getLocation()
        {
            return location;
        }

        public int getID()
        {
            return id;
        }
        
        public bool isActive()
        {
            return active;
        }

        public void setLocation(string location)
        {
            this.location = location;
        }

        public void setActive(bool active)
        {
            this.active = active;
        }

        public virtual string toString()
        {
            return ("Weather Event Location: " + location) + "\n" + ("id: " + id) + "\n" +("active: " + active) + "\n";

        }
    }   
}