using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            bool isInputValid = false;
            string input = null;
            double radius = 0;

            Console.WriteLine("Welcome to the Circle Tester");

            do
            {
                shouldContinue = false;
                do
                {
                    try
                    {
                        isInputValid = true;
                        Console.Write("Enter radius: ");
                        input = Console.ReadLine();
                        radius = double.Parse(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That input is invalid");
                        isInputValid = false;
                    }
                } while (!isInputValid);

                Circle c = new Circle(radius);
                c.CalculateFormattedCircumference();
                Console.WriteLine(c.CalculateFormattedCircumference());
                c.CalculateFormattedArea();
                Console.WriteLine(c.CalculateFormattedArea());

                Console.WriteLine("Continue? (yes/no)");
                input = Console.ReadLine();
                if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true;
                }

            } while (shouldContinue);
            Console.ReadKey();
        }   
    }
}


//display error if user input is invalid
//once valid data is input calculate area and circumference. Round to the nearest 2 decimal places.
//prompt user to continue
//say goodbye and include how many circles were made