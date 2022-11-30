using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment10
{
    internal class Question_Unit
    {
        public string Question { get; set; }
        public string[] Answers { get; private set; }
        public string Explanation { get; set; }
        public string CorrectAnswer { get; set; }

        public Question_Unit(string question, string a, string b, string c, string d, string correctAnswer, string explanation) {
            this.Question = question;
            this.CorrectAnswer = correctAnswer;
            this.Explanation = explanation;

            Answers = new string[4];
            Answers[0] = a;
            Answers[1] = b;
            Answers[2] = c;
            Answers[3] = d;
        }
    }
}
