using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides
            Console.WriteLine("Enter the length of the first side:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the length of the second side:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the length of the third side:");
            string input3 = Console.ReadLine();

            // Parse the inputs
            double side1, side2, side3;
            bool isValid1 = double.TryParse(input1, out side1);
            bool isValid2 = double.TryParse(input2, out side2);
            bool isValid3 = double.TryParse(input3, out side3);

            // Validate input
            if (isValid1 && isValid2 && isValid3 && side1 > 0 && side2 > 0 && side3 > 0)
            {
                // Determine the type of triangle
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numerical values for the sides.");
            }
        }
    }
}
