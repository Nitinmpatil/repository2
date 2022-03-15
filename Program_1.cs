using System;

namespace ConditionalsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local variables --> Method Level scope
            int age, option;
            Console.WriteLine("Enter Your Age: "); // "35"
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Option (1-5): "); // "2"
            option = Convert.ToInt32(Console.ReadLine());

            if (age > 20) // age > 20 is a condition
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("You are not allowed to access this website");
            }

            if(option == 1)
            {
                Console.WriteLine("You have entered: {0}", option);
            }
            else if(option == 2)
            {
                Console.WriteLine("You have entered: {0}", option);
            }
            else if(option == 3)
            {
                Console.WriteLine("You have entered: {0}", option);
            }
            else if (option == 4)
            {
                Console.WriteLine("You have entered: {0}", option);
            }
            else if (option == 5)
            {
                Console.WriteLine("You have entered: {0}", option);
            }
            else
            {
                Console.WriteLine("Please enter a value between 1-5");
            }

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine("You have entered: {0}", option);
                    break;
                case 2:
                    Console.WriteLine("You have entered: {0}", option);
                    break;
                case 3:
                    Console.WriteLine("You have entered: {0}", option);
                    break;
                case 4:
                    Console.WriteLine("You have entered: {0}", option);
                    break;
                case 5:
                    Console.WriteLine("You have entered: {0}", option);
                    break;
                default:
                    Console.WriteLine("Please enter a value between 1-5");
                    break;            

            }
        }
    }
}
