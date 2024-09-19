using System;

namespace Lab5
{
    abstract class Item
    {
        private string title;

        public Item(){
            this.title = "";
        }

        public Item(string title){
            this.title = title;
        }

        public string getTitle(){
            return this.title;
        }

        public void setTitle(string title){
            this.title = title;
        }

        public virtual string getListing(){
            return "this item is called " + this.title + "!";
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}