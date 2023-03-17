using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;
using System.Linq;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        //declared array for student, student marks and grade to store multiple variables
        public string [] Students;
        public int [] StudMarks;
        public int [] GradeProfile;
        //declared mean variable and Student Minimum and Maximum variables
        public double Mean;
        public int StudentMin;
        public int StudentMax;
        //declared constant varaibles for grades

        public const int GradeA = 70;
        public const int GradeB = 60;
        public const int GradeC = 50;
        public const int GradeD = 40;

        //Created the Run method to run the choice menu

        public void Run()
        {
            Console.WriteLine("Welcome To App 3- Student Grades and Marks");
            
            //Created a method for choices display the choices where ysers can press the valud choices to output their choice
            choicemenu();
        }

        public void choicemenu()
        {
            Console.WriteLine(" Please choose the following options: ");
            Console.WriteLine(" 1. Input Student marks ");
            Console.WriteLine(" 2. Output Student Marks ");
            Console.WriteLine(" 3. Output Statistics ");
            Console.WriteLine(" 4. Grade Profile ");

            int choice = Convert.ToInt32(Console.ReadLine());

            //Users have to press either 1, 2 , 3 or 4 otherwise it will output an error message

            if (choice != 1 && choice !=2 && choice !=3 && choice !=4)
            {
                throw new Exception(" Invalid choice, Please Try Again ");
            }

            if(choice == 1)
            {
                StudentMarks();
            }
            if (choice == 2)
            {
                OutputStudent();
            }
            if (choice == 3)
            {
                OutputStats();
            }
            
            if (choice == 4)
            {
                OutputGradeProfile();
            }
            
        }

        //Created an array of list of 10 students, These student names are called when 'Students' is used

        public StudentGrades()
        {
            Students = new string[]
            {
                "Nick", "Sam", "Desmond", "Kate", "Holly", "Donna", "Frohu", "Sha", "Melria", "Tika"
            };
            //Assigned GradeProfile and StudMarks
            GradeProfile = new int[(int)Grades.A + 1];
            
            StudMarks = new int [Students.Length];
        }

        //Created a Student Marks method to input marks for students
        //Created a for loop so it will ask the user to input marks for each 10 students

        public void StudentMarks()
        {
          for (int i = 0; i < Students.Length; i++)
            {
                bool validation = false;
                int mark = 0;

                //Checks if mark is an integer or not, otherwise will output an error message

                while (!validation)
                {
                    Console.Write($"Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine(" Invalid integer ");
                    }
                    else
                    {
                        //if user enters the mark in integer, it returns true and proceed to the next method 
                        validation = true;
                    } 
                }
                StudMarks[i] = mark;
            }
            choicemenu();
        }

        //Output Student method outputs the student marks with their names
        public void OutputStudent()
        {
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($"               List Of Students          ");
            Console.WriteLine(" -----------------------------------------");

            Console.WriteLine(" No: ");
            Console.WriteLine(" Name: ");
            Console.WriteLine(" Mark: ");
            int studentCount = 0;

            //This For loop will output all 10 students marks with their names
            for( int i = 0; i< Students.Length; i++)
            {
               int mark = StudMarks[i];
               string studentNumber = (i + 1).ToString("D2");
               Console.WriteLine(studentNumber);
               //Console.WriteLine(grade);
               Console.WriteLine(Students[i]);
               Console.WriteLine(mark);
               studentCount++;

            }
            //Outputs the total number of students
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($" Total Number of students: {studentCount}");
            Console.WriteLine(" -----------------------------------------");

            choicemenu();
        }

        //Created a method called Convert To Grade so it wil convert student marks and store into grades.

        public Grades ConvertToGrade(int mark)
        {
            //If mark is more than 0 and less than GradeD, then it will return Grade F.This refers to Grades.cs

            if (mark >= 0 && mark < GradeD )
            {
                return Grades.F;
            }
            //If mark is less than GradeC, then it will return Grade D.
            else if (mark < GradeC)
            {
                return Grades.D;
            }
            //If mark is less than GradeB, then it will return Grade C.
            else if (mark < GradeB)
            {
                return Grades.C;
            }
            //If mark is less than GradeA, then it will return Grade B.
            else if (mark < GradeA)
            {
                return Grades.B;
            }
            //Otherswise, it will return to Grade A. 
            else
            {
                return Grades.A;
            }

        }

        //Output Stats method calculates the mean, minimum, maximum
        public void OutputStats()
        {
            //Assigning Student Min and Student Max to StudMarks
            StudentMin = StudMarks[0];
            StudentMax = StudMarks[0];

            //total equals to 0
            double total = 0;
            foreach(int mark in StudMarks)
            {
                //Minimum and Maximum
                if (mark > StudentMax) StudentMin = mark;
                if (mark < StudentMin) StudentMin = mark;

                //Assigned total and mark is total

                total = total + mark;
            }
            //Formula for Mean
            Mean = total / StudMarks.Length;
            //Mean assigns to studentmean
            double studentMean = Mean;
            //Printing out mean, minimum and maximum
            Console.WriteLine("Student Mean: " + studentMean.ToString("F"));
            Console.WriteLine("Student Minimum: " + StudentMin);
            Console.WriteLine("Student Maximum: " + StudentMax);

            choicemenu();

        }

        //Grade Profile method displays how many students have the same grades with percentage.
        //Counts how many student and works out the percentage of how many students achieved the same grades.

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            
            foreach (int mark in StudMarks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            for (int i =0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in StudMarks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }
        public void OutputGradeProfile()
        {
            int[] studentgc = new int[5];

            foreach (int mark in StudMarks)
            {
                if (mark >= GradeA)
                {
                    studentgc[4]++;
                }
                else if (mark >= GradeB)
                {
                    studentgc[3]++;
                }
                else if (mark >= GradeC)
                {
                    studentgc[2]++;
                }
                else if (mark >= GradeD)
                {
                    studentgc[1]++;
                }
                else
                {
                    studentgc[0]++;
                }
            }
            Grades grades = Grades.X;
            foreach (int studcount in studentgc)
            {
                int percentage = studcount * 100 / StudMarks.Length;
                Console.WriteLine($"Grade {grades} {percentage}% Count {studcount}");
                grades++;
            }
            int studentgctotal = studentgc.Sum();

            Console.WriteLine($"Count and percentage student achieved Grade A is: {studentgc[4]} {(double)studentgc[4] / studentgctotal:P}");
            Console.WriteLine($"Count and percentage student achieved Grade B is: {studentgc[3]} {(double)studentgc[3] / studentgctotal:P}");
            Console.WriteLine($"Count and percentage student achieved Grade C is: {studentgc[2]} {(double)studentgc[2] / studentgctotal:P}");
            Console.WriteLine($"Count and percentage student achieved Grade D is: {studentgc[1]} {(double)studentgc[1] / studentgctotal:P}");
            Console.WriteLine($"Count and percentage student achieved Grade F is: {studentgc[0]} {(double)studentgc[0] / studentgctotal:P}");
        }
    }
}