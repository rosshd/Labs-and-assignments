using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Checkings : Account
    {
        public Checkings() : base(){
            
        }

        public Checkings(float balance) : base(balance){

        }

        public override void Withdraw(float withdraw){
            if(this.getBal() - withdraw >= 0){
                this.setBal(this.getBal() - withdraw);
            }else{
                Console.WriteLine("Charging an overdraft fee of $20 because you are below $0");
                this.setBal(this.getBal() - (withdraw + 20));
            }
        }
    }
}