using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Language
{
    public class C
    {
        public static int Scanf()
        {
           var input = Console.ReadLine();

            // Error handling mechanism
            if (input==null)
            {
                Console.WriteLine("This is not a number");
                return 0;
            }
            return int.Parse(input);
        }

        
    }
}