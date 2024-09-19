using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Driver
    {
        static void updateFrequencies(Symbol[] symbols)
        {
            //set total to 0 and add up all the uses from each symbol
            var total = 0;
            foreach(Symbol symbol in symbols)
            {
                total += symbol.uses;
            }
            //setting each frequency to individual symbol uses divided by total symbol uses between all of them
            foreach(Symbol symbol in symbols)
            {
                symbol.frequency = symbol.uses / ((double)total);
            }

        }

        static void sortSymbols(Symbol[] symbols)
        {
            //replicate the array into temp arrays
            Symbol[] tempSymbols = new Symbol[symbols.Length];
            for(int i = 0; i < symbols.Length; i++)
            {
                tempSymbols[i] = symbols[i];
            }
            mergeSort(symbols, 0, symbols.Length, tempSymbols);
        }

        //merge sorting my array
        static void mergeSort(Symbol[] symbols, int start, int end, Symbol[] tempSymbols)
        {
            if(end - start <= 1) return; //if only one item, it is already sorted


            //define the middle of the array and recursively break it in half until it its veiw is only one object in each split
            var middle = (end + start) / 2;

            mergeSort(tempSymbols, start, middle, symbols);
            mergeSort(tempSymbols, middle, end, symbols);
            

            //create middle pointer and starting pointer for merging the two arrays
            var midPointer = middle;
            var startingPointer = start;

            for(int i = start; i < end; i++)
            {
                //if frequncy is higher than the other, set it to i of the array, or if frequency is the same and then alphabetical order
                if(startingPointer < middle && (midPointer >= end || (tempSymbols[startingPointer].frequency > tempSymbols[midPointer].frequency ) || (tempSymbols[startingPointer].frequency == tempSymbols[midPointer].frequency &&  (int)tempSymbols[startingPointer].emoji < (int)tempSymbols[midPointer].emoji)))
                {
                    symbols[i] = tempSymbols[startingPointer];
                    startingPointer++;
                }
                else
                {
                    symbols[i] = tempSymbols[midPointer];
                    midPointer++;
                }
            }

        }

        static void Main(string[] args)
        {
            //filling my symbol array with all of the symbols
            Symbol[] symbols = new Symbol[9];
            Symbol slot1 = new Symbol('\u221E');
            symbols[0] = slot1;
            Symbol slot2 = new Symbol('\u263A');
            symbols[1] = slot2;
            Symbol slot3 = new Symbol('\u2640');
            symbols[2] = slot3;
            Symbol slot4 = new Symbol('\u2642');
            symbols[3] = slot4;
            Symbol slot5 = new Symbol('\u2660');
            symbols[4] = slot5;
            Symbol slot6 = new Symbol('\u2663');
            symbols[5] = slot6;
            Symbol slot7 = new Symbol('\u2665');
            symbols[6] = slot7;
            Symbol slot8 = new Symbol('\u2666');
            symbols[7] = slot8;
            Symbol slot9 = new Symbol('\u266B');
            symbols[8] = slot9;

            //asks what symbol they would like to use until they enter 0, which will break out of the loop.
            while(true)
            {
                //display all the symbols
                for(int i = 1; i <= symbols.Length; i++)
                {
                    Console.WriteLine(i + " - " + symbols[i-1].emoji);
                }
                Console.WriteLine("0 - Exit");

                Console.Write("Please select a symbol to print: ");
                var choice = Int32.Parse(Console.ReadLine() ?? "-1");


                if(choice == 0)break;

                //if valid option, uses variable +1, then update the frequencies for all of them and finally, sort and update the array.
                else if(choice <= 9 && choice > 0)
                {
                    symbols[choice - 1].use();
                    updateFrequencies(symbols);
                    sortSymbols(symbols);
                }
                else Console.WriteLine("Invalid choice, please try again.");

                Console.Write("");
            }
        }
    }
}