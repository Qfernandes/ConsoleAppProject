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
        const double Miles_To_Feet = 5280;
        const double Miles_To_Metres = 1609.34;
        const double Feet_To_Metres = 0.30;
        double fromDistance;
        double toDistance;
        string fromUnit;
        string toUnit;
        public double miles;
        public double feet;
        public double metres;
  
        public void Run()
        {
            Console.WriteLine("Please choose the following choices");
            Console.WriteLine("Select the From Unit:  ");
            fromUnit = unitMenu();
            Console.WriteLine(" Select the To Unit: ");
            toUnit = unitMenu();

            fromDistance = InputUnit(fromUnit);

            ConvertDistance();
            Print();
        }
        public string unitMenu()
        {
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            Console.WriteLine("Please enter the number: ");
            string choice = Console.ReadLine();

            if (choice != "1" && choice !="2" && choice != "3")
            {
                throw new Exception("Invalid choice, Please select only the following choices");
            }

            if (choice == "1")
            {
                return "miles";

            }
            else if (choice == "2")
            {
                return "feet";
            }
            else if (choice =="3")
            {
                return "metres";
            }

            return null;
        }
        public int InputUnit(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
        public void ConvertDistance()
        {
            if (fromUnit == "miles" && toUnit =="feet")
            {
                toDistance = fromDistance * Miles_To_Feet;
            }
            else if (fromUnit == "feet" && toUnit =="miles")
            {
                toDistance = fromDistance / Miles_To_Feet;
            }
            else if (fromUnit == "miles" && toUnit =="metres")
            {
                toDistance = fromDistance * Miles_To_Metres;
            }
            else if (fromUnit == "metres" && toUnit =="miles")
            {
                toDistance = fromDistance / Miles_To_Metres;
            }
            else if (fromUnit == "feet" && toUnit =="metres")
            {
                toDistance = fromDistance * Feet_To_Metres;
            }

            else if (fromUnit == "metres" && toUnit =="feet")
            {
              toDistance = fromDistance / Feet_To_Metres;  
            }

        }
        public void Print()
        {
            Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance + " " + toUnit);
        }
    }
}

        /*

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
            Console.WriteLine(Feets + " feets is " + Miles + " miles " );
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
*/
