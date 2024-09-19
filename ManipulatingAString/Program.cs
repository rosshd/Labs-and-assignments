using System;

namespace Lab_1_1322_Ross_Dawson
{
       class Program
       {
            //Pasted from Lab project document
            public static char[,] make_forward(){
                var pixel = new char[4,13]; 
                    pixel[0,0]=' '; pixel[0,1]=' '; pixel[0,2]='_'; pixel[0,3]='_'; pixel[0,4]='_'; pixel[0,5]='_'; pixel[0,6]='_'; pixel[0,7]='_'; pixel[0,8]=' '; pixel[0,9]=' '; pixel[0,10]=' '; pixel[0,11]=' '; pixel[0,12]=' '; pixel[1,0]=' '; pixel[1,1]='/'; pixel[1,2]='|'; pixel[1,3]='_'; pixel[1,4]='|'; pixel[1,5]='|'; pixel[1,6]='_'; pixel[1,7]='\\'; pixel[1,8]='\''; pixel[1,9]='.'; pixel[1,10]='_'; pixel[1,11]='_'; pixel[1,12]=' '; pixel[2,0]='('; pixel[2,1]=' '; pixel[2,2]=' '; pixel[2,3]=' '; pixel[2,4]='_'; pixel[2,5]=' '; pixel[2,6]=' '; pixel[2,7]=' '; pixel[2,8]=' '; pixel[2,9]='_'; pixel[2,10]=' '; pixel[2,11]='_'; pixel[2,12]='\\'; pixel[3,0]='='; pixel[3,1]='\''; pixel[3,2]='-'; pixel[3,3]='('; pixel[3,4]='_'; pixel[3,5]=')'; pixel[3,6]='-'; pixel[3,7]='-'; pixel[3,8]='('; pixel[3,9]='_'; pixel[3,10]=')'; pixel[3,11]='-'; pixel[3,12]='\''; 
                    return pixel;
            }


            public static char[,] make_reverse(char[,] array){
                //creating new 2d array to assign the array values to
                var reversed = new char[4,13];

                //nested for loops to itterate through the array and assign values to the new reversed array
                for(var i = 0; i < 4; i++){

                    //placeholder for what x value on the array the new char will be assigned to the new reversed array and flipping the ascii if it happens to be one of the charactors that needs flipped
                    var placeholder = 0;
                    for(var x = 12; x >= 0; x--){

                        if(array[i,x].Equals('/')) reversed[i,placeholder] = '\\';

                        else if(array[i,x].Equals('(')) reversed[i,placeholder] = ')';

                        else if(array[i,x].Equals(')')) reversed[i,placeholder] = '(';

                        else if(array[i,x].Equals('\\')) reversed[i,placeholder] = '/';

                        else reversed[i,placeholder] = array[i,x];

                        placeholder++;
                    }
                }

                //return the reversed string
                return reversed;
            }

            //method for printing out the array
            public static void printArray(char[,] array){
                for(var y = 0; y < 4; y++){
                    for(var x = 0; x < 13; x++){
                        Console.Write(array[y,x]);
                    }
                    Console.WriteLine();
                }
            }

            //new methods above main method
            static void Main(string[] args)
            {
                //initialyzing and printing the nonflipped 2d array
                char[,] myArray = new char[4,13];
                myArray = make_forward();
                printArray(myArray);

                //initialyzing a nonflipped array, flipping it, and then printing the flipped array
                char[,] revArray = new char[4,13];
                revArray = make_reverse(myArray);
                printArray(revArray);


                // the nested for loop for having the cars on the same line
                for(var y = 0; y < 4; y++){
                    //goes through one line of each array before breaking to the next line
                    for(var x = 0; x < 13; x++){
                        Console.Write(myArray[y,x]);
                    }
                    for(var x = 0; x < 13; x++){
                        Console.Write(revArray[y,x]);
                    }
                    Console.WriteLine();
                }
            }
       }

}