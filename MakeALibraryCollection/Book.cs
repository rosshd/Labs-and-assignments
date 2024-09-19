using System;

namespace Lab5
{
    class Book : Item
    {
        private int ISBN;
        private string authorName;

        public Book() : base(){
            this.ISBN = 0;
            this.authorName = "";
        }

        public Book(string title, string authorName, int ISBN) : base(title){
            this.authorName = authorName;
            if(ISBN >= 0 && (ISBN/1000000000000) < 10){
                this.ISBN = ISBN;
            }else{
                Console.WriteLine("Invalid ISBN, setting to 0 for now...");
                this.ISBN = 0;
            }
        }

        public string getAuthor(){
            return this.authorName;
        }

        public void setAuthor(string authorName){
            this.authorName = authorName;
        }

        public int getISBN(){
            return this.ISBN;
        }

        public void setISBN(int ISBN){
            if(ISBN >= 0 && (ISBN/1000000000000) < 10){
                this.ISBN = ISBN;
            }else Console.WriteLine("Invalid ISBN, please try again.");
        }

        public override string getListing(){
            return "Book Name - " + this.getTitle() + "\nAuthor - " + this.authorName + "\nISBN # - " + this.ISBN;
        }

    }
}