using System;

namespace Lab6
{
    class Driver
    {
        static void Main(string[] args)
        {

            FibFormula formula = new FibFormula();
            FibIteration iteration = new FibIteration();

            Console.WriteLine("Enter the number you want to find the Fibonacci series for");
            var num = Int32.Parse(Console.ReadLine() ?? "-1");
            Console.WriteLine("Fib of " + num + " by iteration is " + iteration.calculate_fib(num));
            Console.WriteLine("Fib of " + num + " by formula is " + formula.calculate_fib(num));
            
        }
    }
}
