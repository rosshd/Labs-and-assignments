using System;

namespace Lab4
{
    class Savings : Account
    {
        private int deposits = 0;
        private float interest = 1.5f;
        public Savings(float balance) : base(balance){

        }
        
        public override void Deposit(float deposit){
            deposits++;
            Console.WriteLine("This is deposit " + deposits + " to your account");
            if(deposits > 5){
                Console.WriteLine("Charging a fee of $10");
                this.setBal(this.getBal() + (deposit - 10));
            }else this.setBal(this.getBal() + deposit);
        }

        public override void Withdraw(float withdraw){
            if(this.getBal() - withdraw < 500){
                Console.WriteLine("Charging a fee of $10 because your account is now under $500");
                this.setBal(this.getBal() - (withdraw + 10));
            }else this.setBal(this.getBal() - withdraw);
        }

        public void PayInterest(){
            Console.WriteLine("Awarding $" + ((this.getBal() * interest) / 100 ) + " in interest");
            this.setBal(this.getBal() + ((this.getBal() * interest) / 100 ));
        }

    }
}