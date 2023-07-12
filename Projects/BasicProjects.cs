using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Projects
{
    public class BasicProjects
    {
        public void EvenOdd()
        {
            int number;

            // Get the number from the user
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();

            // Error handling mechanism
            if (input==null)
            {
                Console.WriteLine("This is not a number");
                return;
            }


            //Converting the number to int
            number = int.Parse(input);

            // Check if the number is even
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }



        public void Calculator()
        {

        }



        public void circumference ()
        {

        }



        public void GstCalculator()
        {

        }


        
    }
}