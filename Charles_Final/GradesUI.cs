﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Final
{
    internal class GradesUI
    {
        StudentS myStudentS = new StudentS();

        public void MainMethod()
        {
            //instance an object of StudentUI..
            //Call StudentUI->PopulateStudents..
            //Verify file was successfully read.
            //if successfull call DisplayInfo()
            //else display error message.

            myStudentS.PopulateStudents("grades.txt");
            Info info = new Info();
            info.DisplayInfo("Final Application");
            DisplayInfo();
        }

        void DisplayInfo()
        {
            Console.WriteLine("Student id\tLast Name\tAverage  \tGrade\n");

            for (int index = 0; index < myStudentS.ListLength; index++)
            {

                Console.WriteLine(" {0} \t {1}    \t {2}    \t {3}", myStudentS.StudentID(index), myStudentS.StudentLastName(index), myStudentS.StudentAverage(index), myStudentS.StudentGrade(index));
            }
        }
    }
}
