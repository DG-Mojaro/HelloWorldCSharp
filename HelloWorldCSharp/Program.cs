/* Author: DG-Mojaro
 * Date: 08/06/2024
 * 
 * This program aims to contain the basics of syntax and methodology for the useage of C#
 * It will act as a 'Hello World' program, as well as an easy to read reference for those new to C#
 */

//Module imports, similar to python, Java, and many other languages
using System;
using System.Runtime.CompilerServices;

namespace HelloWorldCSharp
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //The below code outputs a welcome screen for the user.
            Console.WriteLine("Welcome to my 'Hello World' program for C#.");
            Console.ReadLine();
            Console.WriteLine("Both the codebase and the program itself have a variety of information on the basic syntax and useage of C#");
            Console.ReadLine();
            Console.WriteLine("Please select a menu option to view a topic in more detail:");
            Console.ReadLine();

            //Initialises the string array that contains the menu options.
            string[] mainMenuOptions = ["Basic console input/output", "Variable Types", "Variable Casting", "Variable Manipulation", "Escape Characters", "Arithmetic operations", "Logical and comparison operators", "If statements", "Loops"];

            //Loops through the menu option array, whilst outputting the index(+1) and option.
            for (int i = 0; i < mainMenuOptions.Length; i++)
            {
                Console.WriteLine((i+1) + ": " + mainMenuOptions[i]);
            }

            //Uses a console.readline statement in combination with a switch case for input for the menu option.
            int mainMenuChoice = Convert.ToInt32(Console.ReadLine());

            switch(mainMenuChoice)
            {
                case 1: //Basic console input/output
                    MenuMethod1();
                    break;
                case 2: //Variable Types
                    MenuMethod2();
                    break;
                case 3: //Variable Casting
                    MenuMethod3();
                    break;
                case 4: //Variable Manipulation
                    MenuMethod4();
                    break;
                case 5: //Escape Characters
                    MenuMethod5();
                    break;
                case 6: //Arithmetic operations
                    MenuMethod6();
                    break;
                case 7: //Logical and comparison operations
                    MenuMethod7();
                    break;
                case 8: //If statements
                    MenuMethod8();
                    break;
                case 9: //Loops
                    MenuMethod9();
                    break;
                default:
                    break;
            }
        }

        static void MenuMethod1()
        {
            //The below code demonstrates the basics of input and output to the console using WriteLine and ReadLine
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my Hello World project for C#.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Use Console.WriteLine() to output a line to the console.");
            Console.WriteLine("Use Console.ReadLine() to take user input and assign it to a variable, like so:");
            string testVar = Console.ReadLine();
            Console.WriteLine("The string you entered was: " + testVar);
            Console.ReadLine();
            Console.WriteLine("Alternatively, use the above statements to enter an empty line, or pause awaiting user input respectively");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You can also manipulate variables with the WriteLine statement:");
            Console.WriteLine("The output of the sum 3+7 is: " + (3 + 7));
        }

        static void MenuMethod2()
        {
            //The code below sets, describes, and then lists out some variable data types
            int testInt = 18;
            double testDouble = 3.14;
            char testChar = 'x';
            bool testBool = false;
            string testString = "This is a String";

            Console.WriteLine("There are many different variable types in C#, most of which are standardised across most programming languages.");
            Console.WriteLine("These include:");
            Console.WriteLine("int - 4 bytes - Stores whole numbers from -2,147,483,648 to 2,147,483,647");
            Console.WriteLine("long - 8 bytes - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            Console.WriteLine("float - 4 bytes - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits");
            Console.WriteLine("double - 8 bytes - Stores fractional numbers. Sufficient for storing 15 decimal digits");
            Console.WriteLine("bool - 1 bit - Stores true or false values");
            Console.WriteLine("char - 2 bytes - Stores a single character/letter, surrounded by single quotes");
            Console.WriteLine("string - 2 bytes per character - Stores a sequence of characters, surrounded by double quotes");

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("For example:");
            Console.WriteLine("This is an example of an int: " + testInt);
            Console.WriteLine("This is an example of an double: " + testDouble);
            Console.WriteLine("This is an example of an char: " + testChar);
            Console.WriteLine("This is an example of an bool: " + testBool);
            Console.WriteLine("This is an example of an string: " + testString);

            Console.ReadLine();
            Console.WriteLine();

            //This code demonstrates the used of a constant
            Console.WriteLine("You can also set a variable as a constant to prevent it from being overwritten elsewhere in the program. For example:");
            Console.WriteLine();

            const double constantTest = 3.14;
            Console.WriteLine("This is now a constant variable: " + constantTest);
        }

        static void MenuMethod3()
        {
            /* This code demonstrates  variable type casting and data type conversion
             * 
             * Type casting is the assigning of a value of one data type to another.
             * There are two examples of this in C#:
             * -Implicit casting: Automatically converting a smaller tpye to a larger type size
             *  -Eg: char -> int -> long -> float -> double
             * -Explicit Casting: Manually converting a larger type to a smaller type size
             *  -Eg: double -> float -> long -> int -> char */

            Console.WriteLine("Variable type casting is the assigning of a value of one data type to another.");
            Console.WriteLine("There are two examples of this in C#:");
            Console.WriteLine(" -Implicit casting: Automatically converting a smaller tpye to a larger type size");
            Console.WriteLine("  -Eg: char -> int -> long -> float -> double");
            Console.WriteLine(" -Explicit Casting: Manually converting a larger type to a smaller type size");
            Console.WriteLine("  -Eg: double -> float -> long -> int -> char");

            Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("The following code is an example of automatic implicit casting:");
            int castingExampleInt = 12;
            double castingExampleDouble = castingExampleInt; //Automatic implicit casting

            Console.WriteLine(castingExampleInt);
            Console.WriteLine(castingExampleDouble);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The following code is an example of manual explicit casting:");
            double castingExampleDouble2 = 3.14;
            int castingExampleInt2 = (int)castingExampleDouble2; //Manual explicit casting: double to int

            Console.WriteLine(castingExampleDouble2);
            Console.WriteLine(castingExampleInt2);

            Console.ReadLine();
            Console.WriteLine();

            //The following code demonstrates explicit type conversion methods
            Console.WriteLine("The following code demonstrates explicit variable type conversion:");
            int typeConversionInt = 11;
            double typeConversionDouble = 6.85;
            bool typeConversionBool = true;

            Console.WriteLine(Convert.ToString(typeConversionInt));
            Console.WriteLine(Convert.ToDouble(typeConversionInt));
            Console.WriteLine(Convert.ToInt32(typeConversionDouble));
            Console.WriteLine(Convert.ToString(typeConversionBool));
        }

        static void MenuMethod4()
        {
            Console.WriteLine("The following code contains examples of assigning, manipulating, modifying and accessing variables of different data types.");
            Console.WriteLine("Please examine the code and the assosiated comments for more information");

            //This code shows how to allocate multiple variables of the same type in a combined single line
            int x = 5, y = 6, z = 7;
            Console.WriteLine("x + y + z = " + (x + y + z));

            int a, b, c;
            a = b = c = 42;
            Console.WriteLine("a + b + c = " + (a + b + c));

            Console.WriteLine();

            //Data read from console.readline is formatted as a string, so needs to be converted if required
            Console.WriteLine("Please enter an integer: ");
            int userInputInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The integer you entered is: " + userInputInt);

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
        }

        static void MenuMethod5()
        {
            //The below code describes and demonstrates the useage of escape characters in C#
            Console.WriteLine("C# uses backslash as an escape character.");
            Console.WriteLine("Some of the use cases are as follows:");
            Console.WriteLine("\\\', \\\", \\\\"); //Note, each useage here requires an escape character to display it correctly in the console

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("This is an example of using an \"escape\" character in a string");
            Console.WriteLine("It\'s possible this could be another example");

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Some other uses of escape characters are:");
            Console.WriteLine("\\n (New line), \\t (Tab), \\b (Backspace)");

            /* The previous mentioned escape characters are listed below for ease of reading:
             * \' (Single quote)
             * \" (Double quote)
             * \\ (Backslash)
             * \n (New line)
             * \t (Tab)
             * \b (Backspace)
             * */
        }

        static void MenuMethod6()
        {
            //The below code describes and then demonstrates some of the arithmetic and assignment operators used in C#.
            Console.WriteLine("C# uses fairly standard arithmetic operators for variable manipulation.");
            Console.WriteLine("These include:");
            Console.WriteLine();
            Console.WriteLine("'+' - Addition");
            Console.WriteLine("'-' - Subtraction");
            Console.WriteLine("'*' - Multiplication");
            Console.WriteLine("'/' - Division");
            Console.WriteLine("'%' - Modulus");
            Console.WriteLine("'++' - Increment");
            Console.WriteLine("'--' - Decrement");

            Console.ReadLine();
            Console.WriteLine();

            //Assignment operators can be used as shorthand and/or in loops
            Console.WriteLine("In addition to this, C# uses fairly standard assignment operators that follow the same logic:");
            Console.WriteLine();
            Console.WriteLine("'+='");
            Console.WriteLine("'-='");
            Console.WriteLine("'*='");
            Console.WriteLine("'/='");
            Console.WriteLine("'%='");
            Console.WriteLine("'&='");
            Console.WriteLine("'|='");
            Console.WriteLine("'^='");
            Console.WriteLine("'>>='");
            Console.WriteLine("'<<='");

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("You can also use the Math method to manipulate variables:");
            Console.WriteLine("Math.Max() returns the highest value");
            Console.WriteLine("Math.Min() returns the lowest value");
            Console.WriteLine("Math.Sqrt() returns the square root");
            Console.WriteLine("Math.Abs returns the absolute (positive) value of the input");
            Console.WriteLine("Math.Round rounds the input to the nearest integer");

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The below code shows the output of various uses of the Math method:");
            Console.WriteLine();

            //The following code demonstrates some uses of the 'Math' method
            Console.WriteLine(Math.Max(5, 7)); //Finds the highest value
            Console.WriteLine(Math.Min(8, 12)); //Finds the lowest value
            Console.WriteLine(Math.Sqrt(81)); //Calculates the square root
            Console.WriteLine(Math.Abs(-2.2)); //Returns the absolute (positive) value of the input
            Console.WriteLine(Math.Round(8.27)); //Round the input to the nearest integer
        }

        static void MenuMethod7()
        {
            //The below code describes the useage of logical operators and comparison operators
            Console.WriteLine("Logical and comparison operators are used in 'if' and boolean statements:");
            Console.WriteLine();
            Console.WriteLine("'==' - Equal to");
            Console.WriteLine("'!=' - Not equal to");
            Console.WriteLine("'>' - Greater than");
            Console.WriteLine("'<' - Less than");
            Console.WriteLine("'>=' - Greater than or equal to");
            Console.WriteLine("'<=' - Less than or equal to");
            Console.WriteLine("'&&' - Logical and");
            Console.WriteLine("'||' - Logical or");
            Console.WriteLine("'!' - Logical not");
        }

        static void MenuMethod8()
        {
            Console.WriteLine("The following code demonstrates examples of if, else if, and shorthand if statements:");

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
        }

        static void MenuMethod9()
        {
            //The below code demonstrates the use of a switch case.
            Console.WriteLine("This is an example of a switch case. Please select an option 1-4:");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
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
                default: //Default will be chosen if the input is outside the expected range.
                    Console.WriteLine("You haven't selected a menu option");
                    break;
            }

            Console.ReadLine();
            Console.WriteLine();

            //The code below demonstrates the use case for a while loop
            Console.WriteLine("This code demonstrates the useage of a while loop:");
            Console.ReadLine();

            int i = 0;
            while (i < 19)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
            Console.WriteLine();

            //This is another alternative for a while loop
            Console.WriteLine("This code demonstrates an alternative useage of a while loop:");
            Console.ReadLine();

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 26);

            Console.ReadLine();
            Console.WriteLine();

            //The following code demonstrates the use of a for loop
            Console.WriteLine("This code demonstrates the useage of a for loop:");
            Console.ReadLine();

            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
            Console.WriteLine();

            //The below code demonstrates a nested loop
            Console.WriteLine("This code demonstrates an example of a nested for loop:");
            Console.ReadLine();

            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine("Outer Loop: " + k);

                for (int l = 0; l <= 17; l++)
                {
                    Console.WriteLine("Inner Loop: " + l);
                }
            }

            Console.ReadLine();
            Console.WriteLine();

            //The below code demonstrates the useage of 'foreach'. This is used to loop through the elements of an array.
            Console.WriteLine("This code demonstrates an example of a foreach loop:");
            Console.ReadLine();

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "VolksWagen" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
            Console.WriteLine();

            //The 'Break' and 'Continue' terms can be used to break a loop as well as a switch case

            //The following code uses 'break' to 'jump out' of a for loop if an 'if' condition is met
            Console.WriteLine("This code demonstrates an example of using 'break' to escape a loop:");
            Console.ReadLine();

            for (int n = 0; n < 11; n++)
            {
                if (n == 6)
                {
                    break;
                }
                Console.WriteLine(n);
            }

            Console.ReadLine();
            Console.WriteLine();

            //The following code uses 'continue' to skip one iteration of a loop if the condition is met, and will then continue
            Console.WriteLine("This code demonstrates an example of using 'continue' to skip one iteration of a loop before continuing:");
            Console.ReadLine();

            for (int m = 0; m < 20; m++)
            {
                if (m == 13)
                {
                    continue;
                }
                Console.WriteLine(m);
            }
        }
    }
}
