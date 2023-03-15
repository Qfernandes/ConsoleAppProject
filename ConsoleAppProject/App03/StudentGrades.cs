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
            Marks = new int [Students.Length];
        }
    
    }
}

        
