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
        double heightIN;
        double weightPD;
        double weightST;
        double heightFT;
        double weightinP;
        double heightinIN;
        double metricbmiResult;
        double imperialbmiResult;

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
            Console.WriteLine("Please enter the weight in stones: ");
            weightST = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the weight in pounds: ");
            weightPD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height in feet: ");
            heightFT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height in inches: ");
            heightIN = Convert.ToDouble(Console.ReadLine());

            weightinP = (weightST * 14) + weightPD;
            Console.WriteLine(" Pounds is " + weightinP );

            heightinIN = (heightFT * 12) + heightIN;
            Console.WriteLine(" Height is " + heightinIN );

            imperialbmiResult = weightinP * 703 / (heightinIN * heightinIN);

            Console.WriteLine(" BMI Result is: " + imperialbmiResult );

            if (imperialbmiResult<=18.50)
            {
                Console.WriteLine("Underweight");
            }

            else if (imperialbmiResult>= 18.5 && imperialbmiResult <= 24.9)
            {
                Console.WriteLine("Healthy");
            }

            else if (imperialbmiResult>= 25.0 && imperialbmiResult <=29.9)
            {
                Console.WriteLine("Overweight");
            }
            else if (imperialbmiResult>= 30.0 && imperialbmiResult <= 34.9)
            {
                Console.WriteLine("Obese Class I");
            }
            else if (imperialbmiResult>= 35.0 && imperialbmiResult <= 39.9)
            {
                Console.WriteLine("Obese Class II");
            }
            else if (imperialbmiResult>=40.0)
            {
                Console.WriteLine("Obese Class III");
            }


        }

        public void metricunits()
        {
            Console.WriteLine("Please enter the weight in kilograms: ");
            weightKG = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter the height in metres: ");
            heightM = Convert.ToDouble(Console.ReadLine());

            metricbmiResult = weightKG / (heightM * heightM);
            
            Console.WriteLine(" Metric BMI Result is: " + metricbmiResult );

            if (metricbmiResult<=18.5)
            {
                Console.WriteLine("Underweight");
            }

            else if (metricbmiResult>= 18.5 && metricbmiResult <= 24.9)
            {
                Console.WriteLine("Healthy");
            }

            else if (metricbmiResult>= 25.0 && metricbmiResult <=29.9)
            {
                Console.WriteLine("Overweight");
            }

            else if (metricbmiResult>= 30.0 && metricbmiResult <= 34.9)
            {
                Console.WriteLine("Obese Class I");
            }

            else if (metricbmiResult>= 35.0 && metricbmiResult <= 39.9)
            {
                Console.WriteLine("Obese Class II");
            }

            else if (metricbmiResult>=40.0)
            {
               Console.WriteLine("Obese Class III"); 
            }
            
        }
    }
}
