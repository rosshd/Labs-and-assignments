using System;

namespace Lab5
{
    class Periodical : Item
    {
        private int issueNum;

        public Periodical() : base(){
            this.issueNum = 0;
        }

        public Periodical(string title, int issueNum) : base(title){
            this.issueNum = issueNum;
        }

        public int getIssueNum(){
            return this.issueNum;
        }

        public void setIssueNum(int issueNum){
            this.issueNum = issueNum;
        }

        public override string getListing(){
            return "Periodical Title - " + this.getTitle() + "\nIssue # - " + this.issueNum;
        }
    }
}