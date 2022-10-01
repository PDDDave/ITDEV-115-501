using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Charles_MidTerm_Election_Program
{
    internal class ElectionUI
    {
        Info info = new Info();
        Election theElection = new Election();

        public void MainMethod() {
            info.DisplayInfo("MidTerm App - Election Program");
            LoadData();
            Clear();
            DisplayResults();
            ReadLine();
        }

        public void DisplayResults() {
            string line = "------------------------------------------------------";
            string heading = "\tName\tVotes\tPercentage";
            double percent = 0.0;

            WriteLine(heading);
            WriteLine(line);
            for(int i = 0; i < theElection.GetNumCandidates(); i++) {
                percent = ((double)theElection.GetCandidateVotes(i) / theElection.TotalVotes());
                WriteLine("\t{0} \t\t {1} \t\t {2}", theElection.GetCandidateName(i), theElection.GetCandidateVotes(i), percent.ToString("P1"));
                //WriteLine("\t" + theElection.GetCandidateName(i) +"\t"+ theElection.GetCandidateVotes(i) + "\t" + (theElection.TotalVotes() / theElection.GetNumCandidates()));    
            }

            WriteLine("\nThe winner is {0}!", theElection.GetCandidateName(theElection.FindWinner()));
        }

        private void LoadData() {
            string inCandidate;
            string inVotes;
            for (int i = 0; i < theElection.GetNumCandidates(); i++) {
                Write("Please enter the name for Candidate number " + (i+1) + ":");
                inCandidate = ReadLine();
                
                while (inCandidate == ""){
                    WriteLine("Oops!  Null value.\n\nPlease enter the name for Candidate number " + (i+1) + ":");
                    inCandidate = ReadLine();
                }

                theElection.SetCandidateName(inCandidate, i);
                Write("Please enter the total votes for " + theElection.GetCandidateName(i) + ":" );
                inVotes = ReadLine();

                while (!int.TryParse(inVotes, out int num)) {
                    Write("Oops! Enter whole numbers only!\n\nPlease enter the total votes for " + theElection.GetCandidateName(i) + ":");
                    inVotes = ReadLine();
                }

                theElection.SetCandidateVotes(int.Parse(inVotes), i);
            }
                
        }
        
    }
}
