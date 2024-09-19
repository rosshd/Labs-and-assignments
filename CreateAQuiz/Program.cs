using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Question> myQuiz = new List<Question>();

            while(true){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a question to the quiz");
                Console.WriteLine("2. Remove a question");
                Console.WriteLine("3. Modify a question in the quiz");
                Console.WriteLine("4. Take the quiz");
                Console.WriteLine("5. Quit");
                
                Console.Write("");
                int action = Int32.Parse(Console.ReadLine() ?? "0");

                if(action == 5) break;
                else if(action == 1){

                    Quiz.NewQuestion();

                }else if(action == 2){

                    Quiz.RemoveQuestion();
                    
                }else if(action == 3){
                    
                    Quiz.ModifyQuestion();

                }else if(action == 4){

                    Quiz.TakeQuiz();

                }
                else Console.WriteLine("Invalid option. Please try again.");

            }
        }
    }
}