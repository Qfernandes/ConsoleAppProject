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
        public void Run()
        {
            //first step
            Console.WriteLine(" Please enter the number of distance: ");
            string input = Console.ReadLine();
            int miles = Convert.ToInt32(input);
            Console.WriteLine(miles);

            //step 2- Process
            const int FEET_TO_MILES = 5200;
            int feet = miles * FEET_TO_MILES;

            //step 3 - output 
            Console.WriteLine(miles + " mile is " + feet + "feet is ");
        }
    }
}
