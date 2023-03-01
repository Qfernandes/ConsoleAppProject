using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.App02;
using ConsoleAppProject.Helpers;
using System;
namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                   By Quincy                      ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("Which program would you like to use: ");
            Console.WriteLine(" 1. Distance Converter ");
            Console.WriteLine(" 2. BMI ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }

            if(choice ==2)
            {
                BMI bMI = new BMI();
                bMI.Run();
            }
        }
    }
}
