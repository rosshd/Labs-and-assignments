using System;

namespace StringSearch
{
    class Driver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the pattern:");
            string pattern = Console.ReadLine();

            int position = findString(text, pattern);

            if (position == -1)
            {
                Console.WriteLine("Pattern not found.");
            }
            else
            {
                Console.WriteLine("Pattern found at position: " + position);
            }
        }

        public static int lengthOfMatch(string str1, string str2)
        {
            if (str1.Length == 0 || str2.Length == 0)
            {
                return 0;
            }

            if (str1[str1.Length - 1] == str2[str2.Length - 1])
            {
                return 1 + lengthOfMatch(str1.Substring(0, str1.Length - 1), str2.Substring(0, str2.Length - 1));
            }
            else
            {
                return 0;
            }
        }

        public static int calculateSkip(char check, string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }

            if (str[str.Length - 1] == check)
            {
                return 0;
            }

            return 1 + calculateSkip(check, str.Substring(0, str.Length - 1));
        }

        public static int findString(string text, string pattern)
        {
            if (pattern.Length > text.Length)
            {
                return -1;
            }

            int matchLength = lengthOfMatch(text.Substring(0, pattern.Length), pattern);

            if (matchLength == pattern.Length)
            {
                return 0;
            }

            int mismatchIndex = matchLength;
            char mismatchedCharacter = pattern[mismatchIndex];

            string subPatternBeforeMatch = pattern.Substring(0, mismatchIndex + 1);
            string subPatternThatMatched = pattern.Substring(mismatchIndex);

            int skip = calculateSkip(mismatchedCharacter, subPatternThatMatched);

            if (skip < subPatternThatMatched.Length)
            {
                skip = 1 + matchLength;
            }
            else
            {
                skip = calculateSkip(mismatchedCharacter, subPatternBeforeMatch);
            }

            if (skip >= text.Length)
            {
                return -1;
            }
            //Console.WriteLine("recursing findstring with : " + text.Substring(skip) + " : " + pattern);
            int result = findString(text.Substring(skip), pattern);

            if (result == -1)
            {
                return -1;
            }
            else
            {
                return skip + result;
            }
        }
    }
}

