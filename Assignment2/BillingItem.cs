using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class BillingItem
    {
        private List<BillingSubitem> myBillingItem;
        private double amount;
        private string description;


        public BillingItem()
        {
            this.amount = 0.0;
            this.description = "";
            this.myBillingItem = new List<BillingSubitem>();
        }

        public BillingItem(double amount)
        {
            this.amount = amount;
            this.description = "";
            this.myBillingItem = new List<BillingSubitem>();
        }

        public BillingItem(double amount, string description)
        {
            this.amount = amount;
            this.description = description;
            this.myBillingItem = new List<BillingSubitem>();
        }

        public double getAmount()
        {
            if(this.myBillingItem.Count > 0)
            {
                double total = 0.0;
                foreach(BillingSubitem subitem in this.myBillingItem)
                {
                    total += subitem.getAmount();
                }
                return (double)((int)(total * 100)) / 100;
            }
            else
            {
                return (double)((int)(this.amount * 100)) / 100;
            }
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void addSubitem(BillingSubitem subitem)
        {
            this.myBillingItem.Add(subitem);
        }

        public void removeSubitem(BillingSubitem subitem)
        {
            if(myBillingItem.Count <= 0) Console.WriteLine("There are no subitems in this subitem!");
            else
            {
                try
                {
                    this.myBillingItem.Remove(subitem);
                    Console.WriteLine("Subitem was removed");
                }
                catch
                {
                    Console.WriteLine("Could not find that item in the this billing item.");
                }
            }
        }

        public string seeItems()
        {
            string text = "";
            if(this.myBillingItem.Count > 0)
            {
                int position = 0;
                foreach(BillingSubitem subitem in this.myBillingItem)
                {
                    text += position + ". " + subitem.toString() + "\n";
                    position++;
                }
                return text;
            }
            else
            {
                return "";
            }
        }

        public BillingSubitem getSubitem(int index)
        {
            if(index >= 0 && index < myBillingItem.Count)
            {
                return myBillingItem[index];
            }
            else
            {
                return null;
            }
        }

        public string toString()
        {
            string text = "";
            text += description;
            if(this.myBillingItem.Count > 0)
            {
                foreach(BillingSubitem subitem in this.myBillingItem)
                {
                    text +=  "\n    " + subitem.getDescription() + ": $" + subitem.getAmount();
                }
            }
            else
            {
                text += ": $" + this.getAmount();
            }
            return text;
        }
    }
}