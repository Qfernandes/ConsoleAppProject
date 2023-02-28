using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        const int Miles_To_Feet = 5280;
        const int Feet_To_Miles = 5280;
        const double Miles_To_Metres = 1609.34;
        private double Miles;
        private double Feets;
        private double Metres;
  
        public void Run()
        {
            MilesToFeet();
            FeetToMiles();
            MilesToMetres();
        }

        public void MilesToFeet()
        {
            //first step
            Console.WriteLine(" Please enter the number of distance miles: ");
            Miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Miles is: " + Miles);

            //step 2- Process
            Feets = Miles * Miles_To_Feet;

            //step 3 - output 
            Console.WriteLine(Miles + " miles is " + Feets + " feets ");
        }
        public void FeetToMiles()
        {
            //step 4
            Console.WriteLine("Enter the number of distance feets: ");
            int Feets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Feet is entered: " + Feets);

            //step 5
            Miles = Feets / Feet_To_Miles;

            //step 6
            Console.WriteLine(Feets + "feets is " + Miles + " miles " );
        }

        public void MilesToMetres()
        {
            //step 7
            Console.WriteLine("Enter the number of distance miles: ");
            double metres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Miles entered is: ");

            //step 8
            Metres = Miles * Miles_To_Metres;

            //step 9
            Console.WriteLine(Miles + " miles is " + Metres + " metres ");
        }
    }
}
