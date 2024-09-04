using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Driver
    {
        static void Main(string[] args)
        {
            Item[] library = new Item[5];
            for(int i = 0; i < 5; i++){
                Console.WriteLine("Please write B for Book or P for Periodical");
                var type = Console.ReadLine() ?? "nothing";
                if(type.ToUpper() == "B"){
                    Console.WriteLine("Please enter the name of the book");
                    var name = Console.ReadLine() ?? "No name";

                    Console.WriteLine("Please enter the author of the book");
                    var authorName = Console.ReadLine() ?? "No author name";

                    Console.WriteLine("Please enter the ISBN of the book");
                    var ISBN = Int32.Parse(Console.ReadLine() ?? "0");

                    library[i] = new Book(name, authorName, ISBN);

                }else if(type.ToUpper() == "P"){
                    Console.WriteLine("Please enter the name of the periodical");
                    var name = Console.ReadLine() ?? "No name";

                    Console.WriteLine("Please enter the issue number of the book");
                    var issueNum = Int32.Parse(Console.ReadLine() ?? "0");

                    library[i] = new Periodical(name, issueNum);

                }else{
                    Console.WriteLine("Invalid option, please try again.");
                    i--;
                }
            }

            Console.WriteLine("Your items:");

            foreach(Item item in library){
                Console.WriteLine(item.getListing());            
                Console.WriteLine();
            }
        }
    }
}