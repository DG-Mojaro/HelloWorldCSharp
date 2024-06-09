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

            //The below code demonstrates some examples of getting user input into the console
            Console.WriteLine("Enter username:");
            string exampleUserName = Console.ReadLine();
            Console.WriteLine("Example Username is: " + exampleUserName);

            Console.WriteLine();

            //Data read from console.readline is formatted as a string, so needs to be converted if required
            Console.WriteLine("Please enter an integer: ");
            int userInputInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The integer you entered is: " + userInputInt);

            Console.WriteLine();

            /* C# uses standard programming arithmetic operators:
             * '+' - Addition
             * '-' - Subtraction
             * '*' - Multiplication
             * '/' - Division
             * '%' - Modulus
             * '++' - Increment
             * '--' - Decrement */

            /* C# also uses standard assignment operators, such as:
             * '+='
             * '-='
             * '*='
             * '/='
             * '%='
             * '&='
             * '|='
             * '^='
             * '>>='
             * '<<='
             * */

            Console.WriteLine();

            //The following code demonstrates some uses of the 'Math' method
            Console.WriteLine(Math.Max(5, 7)); //Finds the highest value
            Console.WriteLine(Math.Min(8, 12)); //Finds the lowest value
            Console.WriteLine(Math.Sqrt(81)); //Calculates the square root
            Console.WriteLine(Math.Abs(-2.2)); //Returns the absolute (positive) value of the input
            Console.WriteLine(Math.Round(8.27)); //Round the input to the nearest integer

            Console.WriteLine();

            //Below are some more eamples of variable manipulation
            string exampleTxt = "Hello World";
            Console.WriteLine("The length of this string is: " + exampleTxt.Length);
            Console.WriteLine(exampleTxt.ToUpper());
            Console.WriteLine(exampleTxt.ToLower());

            //The below code uses interpolation to substitute values into the string
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine($"My full name is: {firstName} {lastName}");

            Console.WriteLine();

            //The below code demonstrates the accessing of characters in a string as an index
            Console.WriteLine(exampleTxt[3]);
            Console.WriteLine(exampleTxt.IndexOf("o"));

            //This following code goes into a little more detail as to the potential methodology
            string fullName = firstName + " " + lastName;
            int charPos = fullName.IndexOf("D");
            Console.WriteLine(fullName.Substring(charPos));

            Console.WriteLine();

            //C# also uses backslash as an escape character
            Console.WriteLine("This is an example of using an \"escape\" character in a string");
            Console.WriteLine("It\'s possible this could be another example");
            /* Other useful escape characters are:
             * \n (New line)
             * \t (Tab)
             * \b (Backspace)
             * */

            //The below code is an example of an if statement
            Console.WriteLine("Please enter your age:");
            int myAge = Convert.ToInt32(Console.ReadLine());
            int votingAge = 18;

            if (myAge > votingAge)
            {
                Console.WriteLine("You are old enough to vote! Congrats! You have been able to vote for " + (myAge - votingAge) + " years");
            }
            else if (myAge == votingAge)
            {
                Console.WriteLine("You are exactly old enough to vote! Congrats on your first time!");
            }
            else
            {
                Console.WriteLine("You're not quite old enough yet, please wait another " + (votingAge - myAge) + " years");
            }

            //An alternate (shorthand) way of writing an if else statement could be as follow:
            int time = 20;
            string result = (time < 18) ? "Good day" : "Good evening";
            Console.WriteLine(result);

            //The below code demonstrates the use of a switch case
            Console.WriteLine("Please enter the menu option: ");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch(menuChoice)
            {
                case 1:
                    Console.WriteLine("You have selected menu option 1");
                    break;
                case 2:
                    Console.WriteLine("You have selected menu option 2");
                    break;
                case 3:
                    Console.WriteLine("You have selected menu option 3");
                    break;
                case 4:
                    Console.WriteLine("You have selected menu option 4");
                    break;
                default:
                    Console.WriteLine("You haven't selected a menu option");
                    break;
            }

            Console.WriteLine();

            //The code below demonstrates the use case for a while loop
            int i = 0;
            while (i < 19)
            {
                Console.WriteLine(i);
                i++;
            }

            //This is another alternative for a while loop
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 26);

            //The following code demonstrates the use of a for loop
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine(j);
            }

            //The below code demonstrates a nested loop
            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("Outer Loop: " + k);

                for (int l = 0; l <= 17; l++)
                {
                    Console.WriteLine("Inner Loop: " + l);
                }
            }

            //The below code demonstrates the useage of 'foreach'. This is used to loop through the elements of an array.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "VolksWagen" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //The 'Break' and 'Continue' terms can be used to break a loop as well as a switch case

            //The following code uses 'break' to 'jump out' of a for loop if an 'if' condition is met
            for (int n = 0; n < 11; n++)
            {
                if (n == 6)
                {
                    break;
                }
                Console.WriteLine(n);
            }

            //The following code uses 'continue' to skip one iteration of a loop if the condition is met, and will then continue
            for (int m = 0; m <20; m++)
            {
                if (m ==13)
                {
                    continue;
                }
                Console.WriteLine(m);
            }
        }
    }
}
