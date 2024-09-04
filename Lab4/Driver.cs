using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Driver
    {
        static void Main(string[] args)
        {

            Checkings checkings = new Checkings();
            Savings savings = new Savings(500f);

            while(true){
                Console.WriteLine("1. Withdraw from Checkings");
                Console.WriteLine("2. Withdraw from Savings");
                Console.WriteLine("3. Deposit to Checkings");
                Console.WriteLine("4. Deposit to Savings");
                Console.WriteLine("5. Balance of Checkings");
                Console.WriteLine("6. Balance of Savings");
                Console.WriteLine("7. Award interest to Savings");
                Console.WriteLine("8. Quit");

                var action = Int32.Parse(Console.ReadLine() ?? "0");

                if(action == 8) break;
                else if(action == 1){
                    Console.WriteLine("How much money would you like to withdraw?");
                    var amount = float.Parse(Console.ReadLine() ?? "0");
                    checkings.Withdraw(amount);
                }
                else if(action == 2){
                    Console.WriteLine("How much money would you like to withdraw?");
                    var amount = float.Parse(Console.ReadLine() ?? "0");
                    savings.Withdraw(amount);
                }
                else if(action == 3){
                    Console.WriteLine("How much money would you like to deposit?");
                    var amount = float.Parse(Console.ReadLine() ?? "0");
                    checkings.Deposit(amount);
                }
                else if(action == 4){
                    Console.WriteLine("How much money would you like to deposit?");
                    var amount = float.Parse(Console.ReadLine() ?? "0");
                    savings.Deposit(amount);
                }
                else if(action == 5){
                    
                    Console.WriteLine("Your balance on checkings " + checkings.getID() + " is " + checkings.getBal() + " dollars.");
                }
                else if(action == 6){
                    Console.WriteLine("Your balance on savings " + savings.getID() + " is " + savings.getBal() + " dollars.");
                }
                else if(action == 7){
                    savings.PayInterest();
                }
                else Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}