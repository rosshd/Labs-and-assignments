using System;

namespace Lab7
{
    class Lab7a
    {
        
        public static int recursive_multiply(int num1, int num2)
        {
           if(num2 == 1)
            {
                return num1;                
            }
            else
            {
                return num1 + recursive_multiply(num1, num2 - 1);
            }
        }

        public static int recursive_div(int num1, int num2)
        {
            if(num1 - num2 < 0)
            {
                return 0;
            }
            else
            {
                return 1 + recursive_div(num1 - num2, num2);
            }
        }

        public static int recursive_mod(int num1, int num2)
        {
            if(num1 < num2)
            {
                return num1;
            }
            else
            {
                return recursive_mod(num1 - num2, num2);
            }
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose from the following:");
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Multiply 2 numbers");
                Console.WriteLine("2. Divide 2 numbers");
                Console.WriteLine("3. Mod 2 numbers");
                Console.Write("");
                int action = Int32.Parse(Console.ReadLine() ?? "5");

                if(action == 0) break;
                else if(action == 1)
                {
                    Console.WriteLine("Please enteryour first number");
                    Console.Write("");
                    int num1 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Please enteryour second number");
                    Console.Write("");
                    int num2 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Answer: " + recursive_multiply(num1, num2));
                }
                else if(action == 2)
                {
                    Console.WriteLine("Please enteryour first number");
                    Console.Write("");
                    int num1 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Please enteryour second number");
                    Console.Write("");
                    int num2 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Answer: " + recursive_div(num1, num2));
                }
                else if(action == 3)
                {
                    Console.WriteLine("Please enteryour first number");
                    Console.Write("");
                    int num1 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Please enteryour second number");
                    Console.Write("");
                    int num2 = Int32.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Answer: " + recursive_mod(num1, num2));
                }
                else Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}