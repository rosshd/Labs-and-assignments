using System;

namespace Lab3
{
    class Quiz
    {

        public static List<Question> myQuiz = new List<Question>();

        public static void NewQuestion(){

            Console.WriteLine("What is the question text?");
            var question = Console.ReadLine() ?? "no question";
            Console.WriteLine("What is the answer?");
            var answer = Console.ReadLine() ?? "no answer";
            Console.WriteLine("How difficult? (1-3)");
            Console.Write("");
            int difficulty = Int32.Parse(Console.ReadLine() ?? "0");
            Question newQues = new Question(question, answer, difficulty);
            myQuiz.Add(newQues);
        }

        public static void RemoveQuestion(){

            Console.WriteLine("Which question would you like to delete?");
                foreach(var quiz in myQuiz){
                    Console.WriteLine(quiz.getID() + ": " + quiz.getQuestion());
                }
                Console.Write("");
                int removalNum = Int32.Parse(Console.ReadLine() ?? "0");
                if  (myQuiz[removalNum - 1]!= null) myQuiz.RemoveAt(removalNum - 1);
                else Console.WriteLine("Invalid Option, please try again.");
        }

        public static void ModifyQuestion(){

            Console.WriteLine("Which question would you like to change?");
            foreach(Question question in myQuiz){
                Console.WriteLine(question.getID() + ": " + question.getQuestion());
            }
            Console.Write("");
                int changeNum = Int32.Parse(Console.ReadLine() ?? "0");
                if  (myQuiz[changeNum - 1] != null){
                    Console.WriteLine("What is the question text?");
                    var question = Console.ReadLine() ?? "no question";
                    myQuiz[changeNum - 1].setQuestion(question);
                    Console.WriteLine("What is the answer?");
                    var answer = Console.ReadLine() ?? "no answer";
                    myQuiz[changeNum - 1].setAnswer(answer);
                    Console.WriteLine("How difficult? (1-3)");
                    Console.Write("");
                    int difficulty = Int32.Parse(Console.ReadLine() ?? "0");
                    if(difficulty >= 1 && difficulty <= 3){
                        myQuiz[changeNum - 1].setDifficulty(difficulty);
                    }else Console.WriteLine("Invalid difficulty, please try again.");
                }
                else Console.WriteLine("Invalid Option, please try again.");
        }

        public static void TakeQuiz(){
            var questionsRight = 0;
            foreach(Question question in myQuiz){
                Console.WriteLine(question.getQuestion());
                var myAnswer = Console.ReadLine() ?? "no answer";
                if(question.getAnswer().ToUpper() == myAnswer.ToUpper()){
                    questionsRight++;
                    Console.WriteLine("Correct");
                }else Console.WriteLine("Incorrect");
            }
            Console.WriteLine("You got " + questionsRight + " out of " + myQuiz.Count + " questions right.");
        }
        
    }
}