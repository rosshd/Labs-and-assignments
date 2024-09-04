using System;

namespace Lab2
{
    class Program
    {



        static void Main(string[] args)
        {
            Item milk = new Item( 3.60f, "milk", "1 Gallon of Milk", 15 );
            Item bread = new Item( 1.98f, "bread", "1 Loaf of Bread", 30 );

            while(true){
                
                Console.WriteLine("1. Sold One Milk");
                Console.WriteLine("2. Sold One Bread");
                Console.WriteLine("3. Change Price of Milk");
                Console.WriteLine("4. Change Price of Bread");
                Console.WriteLine("5. Add Milk to Inventory");
                Console.WriteLine("6. Add Bread to Inventory");
                Console.WriteLine("7. See Inventory");
                Console.WriteLine("8. Quit");

                Console.Write("");

                //prompting user  for what action they want to take and then do the cooresponding action.
                int action = Int32.Parse(Console.ReadLine() ?? "0");
                if(action == 8) break;

                else if(action == 1) milk.sellOneItem();
                else if(action == 2) bread.sellOneItem();

                else if(action == 3) 
                {
                    Console.WriteLine("What is the new price of " + milk.getName() + "?");
                    var price = double.Parse(Console.ReadLine() ?? "0");
                    milk.setCost(price);
                }
                else if(action == 4) 
                {
                    Console.WriteLine("What is the new price of " + bread.getName() + "?");
                    var price = double.Parse(Console.ReadLine() ?? "0");
                    bread.setCost(price);
                }
                else if(action == 5) 
                {
                    Console.WriteLine("How many " + milk.getName() + " did we get?");
                    var quantity = Int32.Parse(Console.ReadLine() ?? "0");
                    milk.addQuantity(quantity);
                }
                else if(action == 6) 
                {
                    Console.WriteLine("How many " + bread.getName() + " did we get?");
                    var quantity = Int32.Parse(Console.ReadLine() ?? "0");
                    bread.addQuantity(quantity);
                }
                else if(action == 7) Console.WriteLine(milk + "\n" + bread);
                else Console.WriteLine("Invalid Imput. Please try again.");

                Console.WriteLine();
            }

        }
    }
}