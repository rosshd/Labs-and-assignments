using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class BillingSubitem
    {
        private double amount;
        private string description;

        public BillingSubitem(double amount, string description)
        {
            this.amount = amount;
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public double getAmount()
        {
            return (double)((int)(this.amount * 100)) / 100;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public string toString()
        {
            return this.description + ": $" + this.amount;
        }
    }
}