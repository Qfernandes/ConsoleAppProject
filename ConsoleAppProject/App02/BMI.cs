using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This is a BMI Calculator, where it can allow the user to calulate their BMI based on their height and weight.
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        //declared the BMI variables
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

        //The Run method runs the choices, whether the user want to calculate their BMI in Imperial Units or Metric Units
        public void Run()
        {
            Console.WriteLine("Welcome To App 2");

            Console.WriteLine("Please choose the following options: ");
            Console.WriteLine(" 1. Imperial Units ");
            Console.WriteLine(" 2. Metric Units ");

            int choice = Convert.ToInt32(Console.ReadLine());

            //if choice 1 or 2 not pressed, then it will output an error message

            if (choice != 1 && choice !=2)
            {
                throw new Exception(" Invalid choice, Please Try Again ");
            }
            
            //added choices, if 1 is pressed, Imperial unit method will run, if 2 is pressed, Metric unit method will run.
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
            //Once the user presses choice 1, imperial unit will run

            //It will ask the user to enter the weight in stones and pounds

            //It will ask the user to enter the height in feet and inches

            Console.WriteLine("Please enter the weight in stones: ");
            weightST = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the weight in pounds: ");
            weightPD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height in feet: ");
            heightFT = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the height in inches: ");
            heightIN = Convert.ToDouble(Console.ReadLine());

            //Once the user enters the weight and height, it will calculate the BMI

            //Stone would be converted into pounds to calculate the BMI weight

            //Feet would be converted into inches to calculate the BMI height

            // Weight in Pounds and Height in inches would be displayed

            weightinP = (weightST * 14) + weightPD;
            Console.WriteLine(" Pounds is " + weightinP );

            heightinIN = (heightFT * 12) + heightIN;
            Console.WriteLine(" Height is " + heightinIN );

            //The new weight and height would be calculated to get the final Imperial BMI

            imperialbmiResult = weightinP * 703 / (heightinIN * heightinIN);

            // Displays the BMI Result

            Console.WriteLine(" BMI Result is: " + imperialbmiResult );

            //Weight Status

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
            //Once the user presses choice 1, metric unit will run

            //It will ask the user to enter the weight in kilograms

            //It will ask the user to enter the height in metres

            Console.WriteLine("Please enter the weight in kilograms: ");
            weightKG = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter the height in metres: ");
            heightM = Convert.ToDouble(Console.ReadLine());

            //Once the user enters the weight and height, it will calculate the BMI

            // Metric Unit Calculation

            metricbmiResult = weightKG / (heightM * heightM);

            //It will display the Metric BMI
            
            Console.WriteLine(" Metric BMI Result is: " + metricbmiResult );

            //Weight Status

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
