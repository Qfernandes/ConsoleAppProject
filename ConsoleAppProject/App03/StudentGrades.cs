using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        public string [] Students;
        public int [] Marks;
        public int [] GradeProfile;
        public double Mean;
        public int Minimum;
        public int Maximum;

        public const int GradeA = 70;
        public const int GradeB = 60;
        public const int GradeC = 50;
        public const int GradeD = 40;
        
        public const int HighestMark = 100;
        public const int LowestMark = 0;



        public void Run()
        {
            Console.WriteLine("Welcome To App 3- Student Grades and Marks");

            choicemenu();
        }

        public void choicemenu()
        {
            Console.WriteLine(" Please choose the following options: ");
            Console.WriteLine(" 1. Input Student marks ");
            Console.WriteLine(" 2. Output Marks ");
            Console.WriteLine(" 3. Output Statistics ");
            Console.WriteLine(" 4. Output Grade Profile ");


            int choice = Convert.ToInt32(Console.ReadLine());

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
            /*
            if (choice == 4)
            {
                OutputGradeProfile();
            }
            */
            
        }
        public StudentGrades()
        {
            Students = new string[]
            {
                "Nick", "Sam", "Desmond", "Kate", "Holly", "Donna", "Frohu", "Sha", "Melria", "Tika"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int [Students.Length];
        }

        public void StudentMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                int mark = 0;

                while (!validInput)
                {
                    Console.Write($"Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine(" Invalid integer ");
                    }
                    else if (mark < 0)
                    {
                      Console.WriteLine(" Invalid mark, cannot accept less than 0 ");
                    }
                    else if (mark>100)
                    {
                        Console.WriteLine(" Invalid mark, cannot more than 100 ");
                    }
                    else
                    {
                        validInput = true;
                    }

                }

                Marks[i] = mark;
            }

            choicemenu();
        }

        public void OutputStudent()
        {
            Console.WriteLine(" No: ");
            Console.WriteLine(" Name: ");
            Console.WriteLine(" Mark: ");
            Console.WriteLine(" Grade: ");
            int studentCount = 0;

            for( int i = 0; i< Students.Length; i++)
            {
               int mark = Marks[i];
               string studentNumber = (i + 1).ToString("D2");
               Console.WriteLine(studentNumber);
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
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;
            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;

                total = total + mark;
            }
            Mean = total / Marks.Length;
            double overallMean = Mean;
            Console.WriteLine($"Overall Mean: {overallMean.ToString("F")}");
            Console.WriteLine($"Minimum: {Minimum}");
            Console.WriteLine($"Maximum: {Maximum}");

            choicemenu();
        }
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            for (int i =0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }
        /*
        public void OutputGradeProfile()
        {
            Grades grade = Grades.X;

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grades {grade} {percentage}% Count {count}");
                grade++;
            }

        }
        */
    }
}

        
