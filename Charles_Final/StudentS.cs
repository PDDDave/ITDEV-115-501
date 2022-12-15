using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Final
{
    internal class StudentS
    {
        List<Student> theStudentList;



        public void PopulateStudents(string path)
        {
            //this is the method you need to implement...NO CONSOLE LOGIC in this file.
            //use the parameter path for file name, and return an error string!!

            //1) create instance of theStudentList (theStudentList = new List<Student>();)
            //2) create an instance of the StreamReader Class to read the data from the file named in the variable path
            //3) Open the File and read line by line using theReadLIne command
            //4) split the line
            //5) create one instance of Student, fill in id, first and last through the constructor
            //6) now loop through remaining fields 3 - 23 for earned and possible and set though method EnterGrade.
            //7) call CalGrade on the Student object - that sets the average and grade.
            //8) Add that Student to theStudentList (theStudentList.Add(aStudent);)
            //9) read next line and loop until null or line = ""
            //10) Close the file

            //do not forgot to use a Try/Catch block.

            theStudentList = new List<Student>();
            

            try {
                using (StreamReader reader = new StreamReader(path)) { //the using statment closes the StreamReader
                    string line;
                    string seperator = ",";
                    string[] strList;

                    while ((line = reader.ReadLine()) != null)
                    {
                        strList = line.Split(seperator);
                        Student student = new Student(strList[0], strList[1], strList[2]);

                        student.EnterGrade(int.Parse(strList[3]), int.Parse(strList[4]));
                        student.EnterGrade(int.Parse(strList[5]), int.Parse(strList[6]));
                        student.EnterGrade(int.Parse(strList[7]), int.Parse(strList[8]));
                        student.EnterGrade(int.Parse(strList[9]), int.Parse(strList[10]));
                        student.EnterGrade(int.Parse(strList[11]), int.Parse(strList[12]));
                        student.EnterGrade(int.Parse(strList[13]), int.Parse(strList[14]));
                        student.EnterGrade(int.Parse(strList[15]), int.Parse(strList[16]));
                        student.EnterGrade(int.Parse(strList[17]), int.Parse(strList[18]));
                        student.EnterGrade(int.Parse(strList[19]), int.Parse(strList[20]));
                        student.EnterGrade(int.Parse(strList[3]), int.Parse(strList[4]));

                        student.CalGrade();
                        theStudentList.Add(student);

                        Array.Clear(strList);
                    }

                   
                }
            }
            catch(Exception e) {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }


        }

        public int ListLength
        {
            get { return theStudentList.Count; }
        }

        public string StudentID(int index)
        {
            return theStudentList.ElementAt(index).ID;
        }

        public string StudentLastName(int index)
        {
            return theStudentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {

            return theStudentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {

            return theStudentList.ElementAt(index).Average;
        }

    }
}

