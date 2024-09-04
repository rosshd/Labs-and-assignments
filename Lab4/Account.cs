using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Account
    {
        private static int nextID = 10001;
        private int id;
        private float balance;

        public Account(){
            this.id = nextID;
            nextID++;
            this.balance = 0.00f;
        }

        public Account(float balance){
            this.balance = balance;
            this.id = nextID;
            nextID++;
        }

        public float getBal(){
            return balance;
        }

        public void setBal(float balance){
            this.balance = balance;
        }

        public int getID(){
            return id;
        }

        public virtual void Withdraw(float withdraw){
            this.balance -= withdraw;
        }

        public virtual void Deposit(float deposit){
            this.balance += deposit;
        }
    }
}