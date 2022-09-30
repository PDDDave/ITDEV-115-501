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
            WriteLine(theElection.GetCandidateName(theElection.FindWinner()));
            WriteLine(theElection.GetCandidateVotes(theElection.FindWinner()));
        }

        public void DisplayResults() { 
        
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
