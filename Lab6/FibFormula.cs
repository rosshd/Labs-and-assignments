using System;

namespace Lab6
{
    class FibFormula : FindFib
    {
        public int calculate_fib(int iterations){
            var finalNum = (int)(Math.Pow((1 + Math.Sqrt(5)) / 2 , iterations) - Math.Pow((1 - Math.Sqrt(5)) / 2 , iterations)) / Math.Sqrt(5);
            return finalNum;
        }
    }
}