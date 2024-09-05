using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Driver
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("[Bill Generator]");
            Bill thisBill = new Bill();
            Console.WriteLine("New bill created");
            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Add subitem");
                Console.WriteLine("4. Remove subitem");
                Console.WriteLine("5. See tax");
                Console.WriteLine("6. Set tax");
                Console.WriteLine("7. Preview bill");
                Console.WriteLine("8. Finish");
                Console.Write("Select option: ");

                var action = Int32.Parse(Console.ReadLine());
                


                if(action == 8)
                {
                    Console.WriteLine();
                    Console.WriteLine(thisBill.toString());
                    Console.WriteLine();
                    Console.Write("Would you like to create a new bill(yes) or shut off the program(no) : ");
                    var choice = Console.ReadLine();
                    Console.WriteLine();

                    if (choice.ToUpper() == "YES")
                    {
                        thisBill = new Bill();
                        Console.WriteLine("New bill created");
                        Console.WriteLine();
                    }
                    else if(choice.ToUpper() == "NO")
                    {
                        Console.WriteLine("Shutting off...");
                        break;
                    }
                    else Console.WriteLine("That was not one of the choices, please try again");
                }
                else if (action == 1)
                {
                    Console.Write("Please enter the items description: ");
                    var description = Console.ReadLine();
                    Console.Write("Please enter the items cost: ");
                    var amount = Int32.Parse(Console.ReadLine());

                    BillingItem newItem = new BillingItem(amount, description);
                    thisBill.addItem(newItem);
                    Console.WriteLine("New item added to the bill");

                }
                else if (action == 2)
                {
                    Console.Write(thisBill.seeItems());
                    Console.Write("Select item to remove: ");
                    var removal = Int32.Parse(Console.ReadLine());

                    thisBill.removeItem(thisBill.getItem(removal));

                }
                else if (action == 3)
                {
                    Console.Write(thisBill.seeItems());
                    Console.Write("Select item to add a subItem to: ");
                    var itemIndex = Int32.Parse(Console.ReadLine());

                    Console.Write("Please enter the subitems description: ");
                    var description = Console.ReadLine();
                    Console.Write("Please enter the subitems cost: ");
                    var amount = Int32.Parse(Console.ReadLine());

                    BillingSubitem newSubitem = new BillingSubitem(amount, description);
                    thisBill.getItem(itemIndex).addSubitem(newSubitem);
                    Console.WriteLine("New subitem added to the bill");
                }
                else if (action == 4)
                {
                    Console.Write(thisBill.seeItems());
                    Console.Write("Select item to remove a subItem from: ");
                    var itemIndex = Int32.Parse(Console.ReadLine());

                    Console.Write(thisBill.getItem(itemIndex).seeItems());
                    Console.Write("Select subitem to remove: ");
                    var removal = Int32.Parse(Console.ReadLine());

                    thisBill.getItem(itemIndex).removeSubitem(thisBill.getItem(itemIndex).getSubitem(removal));
                }
                else if(action == 5)
                {
                    Console.WriteLine("Current tax is " + Bill.getTaxPercentage() + "%");
                }
                else if(action == 6)
                {
                    Console.Write("Enter new tax Percentage %: ");
                    var tax = Double.Parse(Console.ReadLine());
                    Bill.setTax(tax);
                    Console.WriteLine("New tax set to " + tax + "%");
                }
                else if(action == 7)
                {
                    Console.WriteLine(thisBill.toString());
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }

                Console.WriteLine();
            }
        }
    }
}