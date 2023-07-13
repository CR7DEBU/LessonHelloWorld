using System;
using HelloWorld.Languages;
using HelloWorld.Projects;

namespace CheckOddEven
{
    public class Program
    {
        static void Main()
        {
            int a, b;


            C.Printf("Enter a number: ");
            a = C.Scanf();
            C.Printf("Enter a number: ");
            b = C.Scanf();

            a = a + b;
            a = a + b;
            C.Printf("The result is: " + a);
        }
    }
}