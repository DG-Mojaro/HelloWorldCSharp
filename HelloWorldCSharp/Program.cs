using System;

namespace HelloWorldCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The code below includes various basic uses of C#
             * This include arithmetic operators and string concatentation */
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my Hello World project for C#");
            Console.WriteLine("This is a third line to test git commit");
            Console.WriteLine("The output of the sum 3+7 is: " + (3 + 7));


            //The code below sets and then lists out some variable data types
            int testInt = 18;
            double testDouble = 3.14;
            char testChar = 'x';
            bool testBool = false;
            string testString = "This is a String";

            Console.WriteLine("This is the result of multiplying the testInt by the testDouble: " + (testInt * testDouble));
            Console.WriteLine("The testChar is: " + testChar);
            Console.WriteLine("The testBool is: " + testBool + " and the testString is: " + testString);
        }
    }
}
