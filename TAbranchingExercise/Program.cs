using System;
using System.Globalization;

namespace TAbranchingExercise
{
    class Program
    {
        static void Main()
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //The user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            decimal pWeight = Convert.ToByte(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (pWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The user must then be prompted for the package width.
            Console.WriteLine("Please enter the package width:");
            decimal pWidth = Convert.ToByte(Console.ReadLine());

            //Then the package height.
            Console.WriteLine("Please enter the package height:");
            decimal pHeight = Convert.ToByte(Console.ReadLine());

            //Then the package length.
            Console.WriteLine("Please enter the package length:");
            decimal pLength = Convert.ToByte(Console.ReadLine());

            //If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            if ((pWidth + pHeight + pLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The sum total of dimensions are then multiplied by the weight and divided by 100.
            //The result of that calculation is the quote.
            decimal q = ((pWidth + pHeight + pLength) * pWeight) / 100;

            // Convert q to currency format (that was an interesting rabbit hole.)
            string quote = q.ToString("C", new CultureInfo("en-US"));

            //Display the quote to the user as a dollar amount.
            Console.WriteLine("Your estimated total for shipping this package is: " + quote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
