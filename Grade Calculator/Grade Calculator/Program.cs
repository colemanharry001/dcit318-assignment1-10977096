using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            string input = Console.ReadLine();
            int grade;

            // Validate input
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                // Determine letter grade
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the result
                Console.WriteLine($"The letter grade for {grade} is {letterGrade}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}
