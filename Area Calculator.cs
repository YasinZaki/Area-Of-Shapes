using System;

namespace P4_P6_Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //use for the string operation choice
            int operation = 0;
            //stock the result of the operation
            double result = 0;

            bool quit = false;

            while (quit == false)
            {
                //Ask user operation to use
                Console.WriteLine("MENU");
                Console.WriteLine("----");
                Console.WriteLine("Type RECTANGLE for rectangle area calculation");
                Console.WriteLine("Type TRIANGLE for triangle area calculation");
                Console.WriteLine("Type CIRCLE for circle area calculation");
                Console.WriteLine("Type HELP for help file");

                string stringOperation = Console.ReadLine().ToUpper(); ;

                // Convert string choice to integral
                if (stringOperation == "RECTANGLE")
                {
                    operation = 1;
                }
                else if (stringOperation == "TRIANGLE")
                {
                    operation = 2;
                }
                else if (stringOperation == "CIRCLE")
                {
                    operation = 3;
                }
                else if (stringOperation == "HELP")
                {
                    operation = 4;
                }


                //Do someting depending on the operation choose
                switch (operation)
                {
                    case 1:
                        //Ask user for the first number
                        Console.WriteLine("Type the length :");
                        string stringlength = Console.ReadLine();
                        double firstNumber = Convert.ToDouble(stringlength);

                        //Ask user for the second number
                        Console.WriteLine("Type the width :");
                        string stringwidth = Console.ReadLine();
                        double secondNumber = Convert.ToDouble(stringwidth);

                        result = firstNumber * secondNumber;

                        //Show the final calculation
                        Console.WriteLine("\nResult of " + firstNumber + "*" + secondNumber + " = " + result + "m2");
                        Console.ReadKey();
                        break;


                    case 2:
                        //Ask user for the first number
                        Console.WriteLine("Type the length :");
                        string stringHeight = Console.ReadLine();
                        double firstNumberT = Convert.ToDouble(stringHeight);

                        //Ask user for the second number
                        Console.WriteLine("Type the width :");
                        string stringBase = Console.ReadLine();
                        double secondNumberT = Convert.ToDouble(stringBase);

                        result = firstNumberT * secondNumberT / 2;

                        //Show the final calculation
                        Console.WriteLine("\nResult of " + firstNumberT + " " + "*" + " " + secondNumberT + "/2" + " = " + result + "m2");
                        Console.ReadKey();
                        break;

                    case 3:
                        //Ask user for the Radius
                        Console.WriteLine("Type the radius:");
                        string stringRadius = Console.ReadLine();
                        double firstNumberC = Convert.ToDouble(stringRadius);

                        double secondNumberC = Math.PI;

                        result = secondNumberC * firstNumberC * firstNumberC;

                        //Show the final calculation
                        Console.WriteLine("\nResult of " + secondNumberC + "*" + firstNumberC + "squared " + " = " + result + "m2");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Instructions");
                        Console.WriteLine("############\n");
                        Console.WriteLine("Step One: First you write down the shape you need the area from");
                        Console.WriteLine("Step Two: Then you put any numbers in required");
                        Console.WriteLine("Step Three: And then you press enter and find out the area of the shape you selected");
                        Console.WriteLine("Step Four: You then press Y to continue or N to quit");
                        Console.WriteLine("Step Five: If you selected Y you can reCalculate any shape you'd like");
                        Console.ReadKey();
                        break;


                }

                Console.WriteLine("Do you want to run another function? Y/N");
                string Restart = Console.ReadLine().ToUpper();

                if (Restart == "N" || Restart == "NO")
                {
                    quit = true;
                }

                else
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            }

            
            


        }
    }
}
