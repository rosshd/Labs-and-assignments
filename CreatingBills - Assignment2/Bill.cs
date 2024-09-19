using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Bill
    {
        private List<BillingItem> myBill;
        private static int nextID = 1;
        private int id;
        private static double taxPercentage = 0.0;

        public Bill()
        {
            this.id = nextID;
            nextID++;
            myBill = new List<BillingItem>();
        }

        public static void setTax(double tax)
        {
            taxPercentage = tax;
        }

        public static double getTaxPercentage()
        {
            return taxPercentage;
        }

        public void addItem(BillingItem item)
        {
            myBill.Add(item);
        }

        public void removeItem(BillingItem item)
        {
            if (myBill.Count <= 0) Console.WriteLine("No items in list!");
            else
            {
                try
                {
                    myBill.Remove(item);
                    Console.WriteLine("Item deleted");
                }
                catch
                {
                    Console.WriteLine("Cannot find that item in list");
                }
            }
        }

        public BillingItem getItem(int index)
        {
            if(index >= 0 && index < myBill.Count)
            {
                return myBill[index];
            }
            else
            {
                return null;
            }
        }

        public string seeItems()
        {
            string text = "";
            int position = 0;
            foreach(BillingItem item in this.myBill)
            {
                text += position + ". " + item.getDescription() + "\n";
                position++;
            }
            return text;
        }

        public double calculateSubTotal()
        {
            double total = 0.0;
            foreach(BillingItem item in myBill)
            {
                total += item.getAmount();  
            }
            return total;
        }

        public double calculateTotal()
        {
            return (double)((int)(calculateSubTotal() * (1 + taxPercentage) * 100) / 100);
        }

        public string toString()
        {
            string str = "====================================\n# " + id + "\n\n";
            foreach (BillingItem item in this.myBill)
            {
                str += item.toString() + "\n";
            }
            str += "\nSubtotal: $" + calculateSubTotal() + "\n";
            str += "Total: $" + calculateTotal() + "\n====================================";
            return str;
        }
    }
}