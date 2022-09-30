using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_MidTerm_Election_Program
{
    internal class Election
    {
        private const int NUM_OF_CANDIDATES = 5;
        private string[] candidatesNames = new string[NUM_OF_CANDIDATES];
        private int[] votes = new int[NUM_OF_CANDIDATES];

        public void SetCandidateName(string name, int index) { 
            candidatesNames[index] = name;
        }

        public void SetCandidateVotes(int inVotes, int index) {
            votes[index] = inVotes;
        }

        public string GetCandidateName(int index) { 
            return candidatesNames[index];
        }

        public int GetCandidateVotes(int index) {
            return votes[index];
        }

        public int FindWinner() {
            int winner = 0;
            int highest = 0;

            for (int i = 0; i < votes.Length; i++) {
                highest = votes[i];
                if (votes[i] > highest) {
                    winner = i;
                    highest = votes[i];
                }
            }
            return winner;
        }

        public int TotalVotes() {
            int accumulator = 0;
            for (int i = 0; i < votes.Length; i++) {
                accumulator += votes[i];
            }

            return accumulator;
        }

        public int GetNumCandidates()
        {
            return NUM_OF_CANDIDATES;
        }


    }
}
