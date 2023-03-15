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
        public int MinimumSM;
        public int MaximumSM;

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
            /*
            if (choice == 3)
            {
                OutputStats();
            }
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
    }
}

        
