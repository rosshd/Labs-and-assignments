using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Item
    {
        private int id;
        private static int nextID = 0;
        private double cost;
        private int quantity;
        private string name;
        private string description;

        public Item(){
            this.name = "misc. Item";
            this.description = "(this item has no description yet)";
            this.quantity = 0;
            this.cost = 0f;
            this.id = nextID;
            nextID++;
        }

        public Item(double cost, string name, int quantity){
            this.cost = cost;
            this.name = name;
            this.description = "(this item has no description yet)";
            this.quantity = quantity;
            this.id = nextID;
            nextID++;
        }
        public Item(double cost, string name, string description, int quantity){
            this.cost = cost;
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.id = nextID;
            nextID++;
        }

        public Item(string name){
            this.name = name;
            this.description = "(this item has no description yet)";
            this.quantity = 0;
            this.cost = 0f;
            this.id = nextID;
            nextID++;
        }

        public void sellOneItem(){
            this.quantity--;
        }

        public int getID(){
            return id;
        }

        public double getCost(){
            double newCost = (int)((cost + 0.005) * 100);
            return (double)newCost / 100;
        }

        public void setCost(double cost){
            if(cost >= 0) this.cost = cost;
            else Console.WriteLine("This is not a valid price, please try again.");
        }

        public int getQuantity(){
            return quantity;
        }

        public void setQuantity(int quantity){
            if(quantity >= 0) this.quantity = quantity;
            else Console.WriteLine("That is not a valid quantity, please try again.");
        }

        public void addQuantity(int quantity){
            if(quantity >= 0) this.quantity += quantity;
            else Console.WriteLine("That is not a valid quantity, please try again.");
        }

        public string getName(){
            return this.name;
        }

        public void setName(string name){
            this.name = name;
        }

        public string getDescription(){
            return description;
        }

        public void setDescription(string description){
            this.description = description;
        }

        public override string ToString()
        {
            return name + ": Item number " + id + ": is " + description + " has price " + this.getCost() + " we currently have " + quantity + " " + name + " in stock";
        }
    }
}