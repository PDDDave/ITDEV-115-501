using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment4
{
    internal class MagicPC
    {
        internal string GetUserAnswer()
        {
            string[] answers = {"Yes.", "No.", "Maybe..", "You already know the answer to that one...", "I didn't quite catch that, speak up.", "In time it will be so",
                                "Without a doubt!", "No way", "If you try, you will succeed", "Not at all"};
            Random rando = new Random();
            int randomNum = rando.Next(answers.Length);

            return answers[randomNum];
        }
    }
}
