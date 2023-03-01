using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        double weightKG;
        double heightM;
        double bmiResult;

        public void Run()
        {
            Console.WriteLine(" Welcome To App 2 ");

            Console.WriteLine("Please enter the weight: ");
            weightKG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height: ");
            heightM = Convert.ToDouble(Console.ReadLine());

            bmiResult = weightKG / (heightM * heightM);

            Console.WriteLine(" BMI Result is: " + bmiResult );

            if (bmiResult<=18.5)
            {
                Console.WriteLine("Underweight");
            }

            else if (bmiResult>= 18.5 && bmiResult <= 24.9)
            {
                Console.WriteLine("Healthy");
            }

            else if (bmiResult>= 25.0 && bmiResult <=29.9)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmiResult>= 30.0 && bmiResult <= 34.9)
            {
                Console.WriteLine("Obese Class I");
            }
            else if (bmiResult>= 35.0 && bmiResult <= 39.9)
            {
                Console.WriteLine("Obese Class II");
            }
            else if (bmiResult>=40.0)
            {
                Console.WriteLine("Obese Class III");
            }


        }
    }
}
