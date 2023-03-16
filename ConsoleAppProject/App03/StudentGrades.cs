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

        public string [] Students;
        public int [] StudMarks;
        public int [] GradeProfile;
        public double Mean;
        public int StudentMin;
        public int StudentMax;

        public const int GradeA = 70;
        public const int GradeB = 60;
        public const int GradeC = 50;
        public const int GradeD = 40;

        public void Run()
        {
            Console.WriteLine("Welcome To App 3- Student Grades and Marks");

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

            //if choice 1, 2, 3 or 4 not pressed, then it will output an error message

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
        public StudentGrades()
        {
            Students = new string[]
            {
                "Nick", "Sam", "Desmond", "Kate", "Holly", "Donna", "Frohu", "Sha", "Melria", "Tika"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            
            StudMarks = new int [Students.Length];
        }

        public void StudentMarks()
        {
          for (int i = 0; i < Students.Length; i++)
            {
                bool validation = false;
                int mark = 0;

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
                        validation = true;
                    } 
                }
                StudMarks[i] = mark;
            }
            choicemenu();
        }

        public void OutputStudent()
        {
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($"               List Of Students          ");
            Console.WriteLine(" -----------------------------------------");

            Console.WriteLine(" No: ");
            Console.WriteLine(" Name: ");
            Console.WriteLine(" Mark: ");
            int studentCount = 0;

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
            Console.WriteLine(" -----------------------------------------");
            Console.WriteLine($" Total Number of students: {studentCount}");
            Console.WriteLine(" -----------------------------------------");

            choicemenu();
        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < GradeD )
            {
                return Grades.F;
            }
            else if (mark < GradeC)
            {
                return Grades.D;
            }
            else if (mark < GradeB)
            {
                return Grades.C;
            }
            else if (mark < GradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }

        }
        public void OutputStats()
        {
            StudentMin = StudMarks[0];
            StudentMax = StudMarks[0];

            double total = 0;
            foreach(int mark in StudMarks)
            {
                if (mark > StudentMax) StudentMin = mark;
                if (mark < StudentMin) StudentMin = mark;

                total = total + mark;
            }
            Mean = total / StudMarks.Length;
            double studentMean = Mean;
            Console.WriteLine("Student Mean: " + studentMean.ToString("F"));
            Console.WriteLine("Student Minimum: " + StudentMin);
            Console.WriteLine("Student Maximum: " + StudentMax);

            choicemenu();

        }
        
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
    }
}