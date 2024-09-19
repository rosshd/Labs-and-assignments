using System;

namespace Lab6
{
    class FibIteration : FindFib
    {
        public int calculate_fib(int iterations){
            if(iterations < 0){
                Console.WriteLine("Invalid input, returning -1...");
                return -1;
            }else if(iterations == 0){
                return 0;
            }else if(iterations <= 2){
                return 1;
            }else{
                int reference1 = 1;
                int reference2 = 1;
                int finalNum = reference1 + reference2;
                for(int i = 3; i <= iterations; i++){
                    finalNum = reference1 + reference2;
                    reference1 = reference2;
                    reference2 = finalNum;
                }
                return Math.Abs(finalNum);
            }
        }
    }
}