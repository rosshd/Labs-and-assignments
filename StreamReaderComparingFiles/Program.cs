using System;
using System.IO;

namespace Lab9
{
    class Program
    {

        public static void Main(string[] args)
        {

            StreamReader sr2 = null;
            StreamReader sr1 = null;
            bool isValid = true;
            var fileName = "";

            try
            {
                Console.Write("Enter file name 1: ");
                fileName = Console.ReadLine() ?? "genericFile.txt";
                sr1 = new StreamReader(fileName);

                Console.Write("Enter file name 2: ");
                fileName = Console.ReadLine() ?? "gerericFile.txt";
                sr2 = new StreamReader(fileName);
            }
            catch
            {
                isValid = false;
                Console.WriteLine("Can not find " + fileName);
            }


            if(isValid)
            {

                var line1 = "";
                var line2 = "";
                var lineNumber = 0;
                var difference = "";
                try
                {
                    while(!sr1.EndOfStream || !sr2.EndOfStream)
                    {
                        if(sr1.EndOfStream)
                        {
                            throw new Exception("Text file 2 longer than text file 1.");
                        }
                        if(sr2.EndOfStream)
                        {
                            if(lineNumber == 0)
                            {   
                                throw new Exception("Text file 1 is empty of does not exist.");
                            }
                            throw new Exception("Text file 3 longer than text file 1.");
                        }
                        lineNumber++;
                        line1 = sr1.ReadLine();
                        line2 = sr2.ReadLine();
                        if(!line1.Equals(line2))
                        {
                            difference += ("Line " + lineNumber + "\n") + ("< " + line1 + "\n") + ("> " + line2 + "\n");
                        }
                    }
                    Console.Write(difference);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}