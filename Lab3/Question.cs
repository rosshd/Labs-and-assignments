using System;

namespace Lab3
{
    class Question
    {
        private int id;
        private static int nextID = 1;
        private string question;
        private string answer;
        private int difficulty;


        public Question(){
            this.id = nextID;
            nextID++;
            this.question = "What is 1 + 1?";
            this.answer = "2";
            this.difficulty = 1;
        }

        public Question(string question, string answer, int difficulty){
            this.id = nextID;
            nextID++;
            this.question = question;
            this.answer = answer;
            this.difficulty=difficulty;
        }

        public string getQuestion(){
            return question;
        }

        public string getAnswer(){
            return answer;
        }

        public int getDifficulty(){
            return difficulty;
        }

        public int getID(){
            return id;
        }

        public void setQuestion(string question){
            this.question = question;
        }

        public void setAnswer(string answer){
            this.answer = answer;
        }

        public void setDifficulty(int difficulty){
            this.difficulty = difficulty;
        }

    }
}
