using System;

namespace Lab7
{
    class Lab7b
    {

        public static string repeatNTimes(string str, int nTimes)
        {
            if(nTimes <= 0)
            {
                return "";
            }
            else
            {
                return str + repeatNTimes(str, nTimes - 1);
            }
        }

        public static bool isReverse(string str1, string str2)
        {
            if(str2.Length == 0 && str1.Length == 0) return true;

            else if(str2.Length != str1.Length) return false;

            else
            {
                if(str1[0] != str2[str2.Length - 1]) return false;

                else
                {
                    return isReverse(str1.Substring(1), str2.Substring(0, str2.Length - 1));
                }

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(repeatNTimes("I must study recursion until it makes sense\n", 100));

            Console.WriteLine("Please enter the first string");
            var str1 = Console.ReadLine() ?? "";
            
            Console.WriteLine("Please enter the second string");
            var str2 = Console.ReadLine() ?? "";

            if(isReverse(str1, str2))
            {
                Console.WriteLine(str1 + " is the reverse of " + str2);
            }
            else
            {
                Console.WriteLine(str1 + " is not the reverse of " + str2);
            }
        }
    }
}