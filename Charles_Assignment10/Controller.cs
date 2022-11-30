using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Charles_Assignment10
{
    internal class Controller
    {
        Info info = new Info();

        Question_Bank qBank = new Question_Bank();

        string fileName = @"C:/Text.txt";
        bool cont = true;
        int counter = 0;

        public void MissionStart() {
            Welcome();
            Play();
        }

        private void Welcome()
        {
            info.DisplayInfo("Assignment 10");

            if (CheckFile())
            {
                LoadQuestions();
            }
            else {
                Console.WriteLine("The file {0} does not exist on current directory: ", fileName);
                Continue();
                System.Environment.Exit(0);
            }
            Continue();
        }

        private void LoadQuestions()
        {
            StreamReader inputFile = new StreamReader(fileName);
            string question;
            string a,b,c,d;
            string correctAnswer;
            string explanation;

            for (int i = 0; i < qBank.questionBank.Length; i++) 
            {
                try
                {
                    question = inputFile.ReadLine();
                    a = inputFile.ReadLine();
                    b = inputFile.ReadLine();
                    c = inputFile.ReadLine();
                    d = inputFile.ReadLine();
                    correctAnswer = inputFile.ReadLine();
                    explanation = inputFile.ReadLine();

                    qBank.questionBank[i] = new Question_Unit(question, a, b, c, d, correctAnswer, explanation);

                }
                catch (FileNotFoundException e) { 
                    Console.WriteLine($"{e.Message}");
                }
                
            }
        }

        private bool CheckFile() {
            bool exists = false;

            if (File.Exists(fileName)) {
                exists = true;
            }
            
            return exists;
        }

        public void Play() {
            string response;

            while (cont) {
                for (int i = 0; i < qBank.questionBank.Length; i++) {
                    Console.Clear();
                    PrintQuestion(i);
                    response = Console.ReadLine().ToUpper();

                    if (qBank.questionBank[i].CorrectAnswer.Equals(response)) {
                        Console.WriteLine("\n\nCorrect!\n\n" + qBank.questionBank[i].Explanation);
                        counter++;
                    }
                    else { 
                        Console.WriteLine("\n\nOops!  Wrong answer...\nThe correct answer was: " + qBank.questionBank[i].CorrectAnswer);
                    }
                    Continue();

                }
                Console.WriteLine("Thank you for Playing!\nYou got {0}/5 questions correct!", counter);
                PlayAgain();        
            }
        
        }

        private void PrintQuestion(int i)
        {
            Console.WriteLine(qBank.questionBank[i].Question + "\n");
            Console.WriteLine("A.\t{0}", qBank.questionBank[i].Answers[0]);
            Console.WriteLine("B.\t{0}", qBank.questionBank[i].Answers[1]);
            Console.WriteLine("C.\t{0}", qBank.questionBank[i].Answers[2]);
            Console.WriteLine("D.\t{0}", qBank.questionBank[i].Answers[3]);

            Console.WriteLine("\n\nEnter the letter for the corresponding answer.\n\n");

        }

        private void PlayAgain() {
            string response;

            Console.WriteLine("Would you like to play again? Y||N");
            response = Console.ReadLine().ToLower();

            if (response != "y") { 
                cont= false;
            }

        }

        private void Continue() { 
            Console.WriteLine("\n\nPress enter to continue...");
            Console.ReadLine();
        }


    }
}
