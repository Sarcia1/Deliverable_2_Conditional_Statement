
using System;

namespace Deliverable_2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expected grade below:");

            try
            {
                int grade = int.Parse(Console.ReadLine());
                
                if (grade >= 90)
                {
                    Console.WriteLine("You letter grade will be an A.");
                }
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your letter grade will be a B.");
                }
                else if ((grade >= 70) && (grade <= 79))
                {
                    Console.WriteLine("Your letter grade will be a C.");
                }
                else if ((grade >= 60) && (grade <= 69))
                {
                    Console.WriteLine("Your letter grade will be a D.");
                }
                else
                {
                    Console.WriteLine("Your letter grade will be a F.");
                }
            }
            catch
            {
                Console.WriteLine("Enter an integer data type for expected grade");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }

        }
    }
}