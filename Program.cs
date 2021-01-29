// Author = Maria Martin
// Date = 1/28/2021
//Comments = This console application demostrates the use of iterative statements after getting input from users.


using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer value between 1 and 100: ");

            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);

                if ((number >= 1) && (number <= 100))
                {
                    Console.WriteLine("Executing a For loop");
                    Console.WriteLine("You have entered " + number.ToString());
                  for (int i=1; i<=number; i++)
                    {
                        Console.WriteLine("You have entered " + number.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                        
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
   }
}
