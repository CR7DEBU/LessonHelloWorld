using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata;
using HelloWorld.Languages;
using HelloWorld.Lessons;

namespace HelloWorld
{
    public class Program
    {
        static void Main()
        {

            C.Printf("Input the function (1 for Triangle, 2 for Others.... : )");
            int inp = C.Scanf();

            // C.Printf("Input first value: ");
            // int x, y;
            // x = C.Scanf();
            // C.Printf("Input second value: ");
            // y = C.Scanf();

            C.Printf("Input row count : ");
            int row = C.Scanf();


            if (inp == 1)
            {
                Pattern.Triangle(row);
            }
            else
            {
                
            }

        }


    }
}

