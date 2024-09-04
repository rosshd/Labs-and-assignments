using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Symbol
    {
        public int uses {get; set;}
        public char emoji {get; set;}
        public double frequency {get ; set;}

        public Symbol(char emoji)
        {
            this.emoji = emoji;
            this.uses = 0;
            this.frequency = 0;
        }

        public void use()
        {
            this.uses++;
        }

        

    }
}