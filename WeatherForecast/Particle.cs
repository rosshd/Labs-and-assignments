using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Particle : Obscuration
    {
        private string particleType;

        public Particle(string location, bool active, int visibility, string particleType) : base(location, active, visibility)
        {
            if(particleType.ToUpper() == "DUST" || particleType.ToUpper() == "SAND" || particleType.ToUpper() == "ASH")
            {
                this.particleType = particleType;
            }
            else this.particleType = "Other";
        }

        public string getParticleType()
        {
            return particleType;
        }

        public void setParticleType(string particleType)
        {
            if(particleType.ToUpper() == "DUST" || particleType.ToUpper() == "SAND" || particleType.ToUpper() == "ASH")
            {
                this.particleType = particleType;
            }
            else this.particleType = "Other";
        }

        public override string toString()
        {
            return base.toString() + "Particle Type: " + particleType + "\n";
        }
    }   
}