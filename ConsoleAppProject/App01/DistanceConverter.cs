using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This is a Distance Converter where the user can convert their distance from and to miles, feet and metres
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    { 
        //declared the distance conversion constants
        const double Miles_To_Feet = 5280;
        const double Miles_To_Metres = 1609.34;
        const double Feet_To_Metres = 0.30;

        //declared distance variables
        double fromDistance;
        double toDistance;
        
        //declared unit variables
        string fromUnit;
        string toUnit;
        public double miles;
        public double feet;
        public double metres;

        //The Run method runs the choices, from unit- unitmenu, to unit- unit menu, input unit, convert distance method and print method
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

        //Created a Unit Method to run the choices, user can see which choices to select
        public string unitMenu()
        {
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            Console.WriteLine("Please enter the number: ");
            string choice = Console.ReadLine();

            //if choice 1,2 or 3 not pressed, then it will output an error message
            if (choice != "1" && choice !="2" && choice != "3")
            {
                throw new Exception("Invalid choice, Please select only the following choices");
            }

            //added choices, if 1 is pressed it will return miles, if 2 is pressed it will retun feet, if 3 is pressed it will retun metres

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
        //  Once the user chose the distance units, the Input Unit method will run and the 'prompt' will automatically assign to the chosen unit and ask the user to enter the number
        //  If the user does not input a number it will show an error message
        public int InputUnit(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);
            return Convert.ToInt32(Console.ReadLine());
        }
        //Created a Convert Distance method, once the user selects the 'to and from' units and enters the distance it will calculate the 'to distance'
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
        // The Print method prints the 'from Distance', 'from Unit', 'to Distance' and 'to Unit', once the user selects the units and enters the distance.
        public void Print()
        {
            Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance + " " + toUnit);
        }
    }
}