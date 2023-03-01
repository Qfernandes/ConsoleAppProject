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
        double weightPD;
        double heightIN;
        double metricbmiResult;

        public void Run()
        {
            Console.WriteLine("Welcome To App 2");

            Console.WriteLine("Please choose the following options: ");
            Console.WriteLine(" 1. Imperial Units ");
            Console.WriteLine(" 2. Metric Units ");

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                imperialunits();

            }

            if (choice == 2)
            {
                metricunits();
            }
        }

        public void imperialunits()
        {
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

        public void metricunits()
        {
            Console.WriteLine("Please enter the weight: ");
            weightPD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height: ");
            heightIN = Convert.ToDouble(Console.ReadLine());

            metricbmiResult = weightPD * 703 / (heightIN * heightIN);
            
            Console.WriteLine(" Metric BMI Result is: " + metricbmiResult );
        }
    }
}
