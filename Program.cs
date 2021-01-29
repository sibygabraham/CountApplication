using System;

namespace CountApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <=100))
                {
                    Console.WriteLine("You have entered " + value_of_input.ToString());
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The Current integer value in the loop : " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program");
                    
                    

          
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value between 1 and 100");
                Console.WriteLine("Please eneter any key to exit the program");
                Console.ReadKey(true);
                
            }
        }
    }
}
