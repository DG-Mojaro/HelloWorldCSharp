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

            Console.WriteLine();

            //The code below sets and then lists out some variable data types
            int testInt = 18;
            double testDouble = 3.14;
            char testChar = 'x';
            bool testBool = false;
            string testString = "This is a String";

            Console.WriteLine("This is the result of multiplying the testInt by the testDouble: " + (testInt * testDouble));
            Console.WriteLine("The testChar is: " + testChar);
            Console.WriteLine("The testBool is: " + testBool + " and the testString is: " + testString);

            Console.WriteLine();

            //This code demonstrates the used of a constant
            const double constantTest = 3.14;
            double newDouble = (constantTest + testDouble);
            Console.WriteLine(newDouble);

            Console.WriteLine();

            //This code shows how to allocate multiple variables of the same type in a combined single line
            int x = 5, y = 6, z = 7;
            Console.WriteLine("x + y + z = " + (x + y + z));

            int a, b, c;
            a = b = c = 42;
            Console.WriteLine("a + b + c = " + (a + b + c));

            Console.WriteLine();

            /* This code demonstrates  variable type casting and data type conversion
             * 
             * Type casting is the assigning of a value of one data type to another.
             * There are two examples of this in C#:
             * -Implicit casting: Automatically converting a smaller tpye to a larger type size
             *  -Eg: char -> int -> long -> float -> double
             * -Explicit Casting: Manually converting a larger type to a smaller type size
             *  -Eg: double -> float -> long -> int -> char */

            int castingExampleInt = 12;
            double castingExampleDouble = castingExampleInt; //Automatic implicit casting

            Console.WriteLine(castingExampleInt);
            Console.WriteLine(castingExampleDouble);

            Console.WriteLine();

            double castingExampleDouble2 = 3.14;
            int castingExampleInt2 = (int) castingExampleDouble2; //Manual explicit casting: double to int

            Console.WriteLine(castingExampleDouble2);
            Console.WriteLine(castingExampleInt2);

            Console.WriteLine();

            //The following code demonstrates explicit type conversion methods
            int typeConversionInt = 11;
            double typeConversionDouble = 6.85;
            bool typeConversionBool = true;

            Console.WriteLine(Convert.ToString(typeConversionInt));
            Console.WriteLine(Convert.ToDouble(typeConversionInt));
            Console.WriteLine(Convert.ToInt32(typeConversionDouble));
            Console.WriteLine(Convert.ToString(typeConversionBool));

            Console.WriteLine();
        }
    }
}
