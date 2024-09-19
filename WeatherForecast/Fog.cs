using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Fog : Obscuration
    {
        private bool freezingFog;

        public Fog(string location, bool active, int visibility, bool freezingFog) : base(location, active, visibility)
        {
            this.freezingFog = freezingFog;
        }

        public bool getFreezingFog()
        {
            return freezingFog;
        }

        public override void setVisibility(int visibility)
        {
            if(visibility < 1)
            {
                base.setVisibility(1);
            }
            else if(visibility > 4)
            {
                base.setVisibility(4);
            }
            else base.setVisibility(visibility);
        }

        public void setFreezingFog(bool freezingFog)
        {
            this.freezingFog = freezingFog;
        }

        public override string toString()
        {
            if(freezingFog)
            {
                return base.toString() + "ALERT! FREEZING FOG!";
            }
            else return base.toString();
        }
    }   
}