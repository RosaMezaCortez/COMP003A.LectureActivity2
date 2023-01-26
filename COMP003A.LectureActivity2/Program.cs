/*
 * Author: Rosa Meza
 * Course: COMP-003A
 * Purpose: Lecture activities for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
 */

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        public static object subtraction { get; private set; }

        static void Main(string[] args)
        {
            /* working with variables */
            //thhe following code shows all three primary varibale-related activities:
            string username; // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); //request for user input
            username = Console.ReadLine(); //assigning a value to a variable (2 of 3)
            Console.WriteLine("Hi " + username); //retrieving its current value (3 of 3)


            // another example of the three primary variable related activities (declaring, assigning, and retrieving)
            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            /*working with variable integers */
            int score; // decalre a new variable with a data typ int
            // score = "Generic User"; // will fail to compile because you are assigning a strong value to an integer variable
            // score = "0"; // will still fail to compile because the "0" is still assigned as a string -  enclosed in the double quotes
            score = 0; // works 
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;



            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            /* variables are case-sensitive */
            // the variables below are different despite haviing similar names 
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************");
            /*
             * types of variables and values matter in C#. they are not interchangable.
             * therfe are eight integer types for storing integers of differing sizes and ranges: int, short, lomg, byte, sbyte, uint, ushort, and ulong.
             * *the char type stores single characters.
             * *the string type stores longer text
             * there are three types for storing real numbers: float, double, and decimal.
             * *the bools type stores truth values (true and false) used in logic.
             * these types are the building blopcks of a much larger type system.
             * using var for a varibale's type tells the compiler to infer its type frp, the surrounding code, so you do not have to type it out. (but it still has a specific type)
             * the System.Convert class is a usful class to convert from one type to another.
             * */

            /* declaring and usin variables with integer types */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInteger = 2147483647;

            /* declaring using, and concatenating characters ans strings */
            char aLetter = 'A';// character values are enclosed in single quotes 
            string message = "Hello World!"; //string values are enclosed in double quotes

            Console.WriteLine("Concatenation using + : " + aLetter + " " + message); // use the plus  (+) sign in between characters/strings to concatenate 
            Console.WriteLine($"Concatenation using string interpolation : {aLetter}{message}");//USEstring interpolation with a dollar-sign ($) beforfe the opening double-qupte and enclosing variables with curly braces ({variableName})

            /* floating-point types */
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");

            /* scientific notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogradosNumber: {avogadrosNumber}");

            /* bool type */
            bool itWorked = true;
            Console.WriteLine($"new value of itWorked: {itWorked}");
            itWorked= false;
            Console.WriteLine($"New value of itWorked: {itWorked}");

            /* convert */
            string inputAgeString;
            int inputAge;
            int CurrentYear = 2023;

            Console.WriteLine($"Enter age in {CurrentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("**************************************************");
            /*
             * math operation
             * addition: +
             * subtraction: -
             * multiplication: *
             * division: /
             * modulo: % (remainder)
             */
            int addition = 2 + 3;
            int subraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");

            /*
             * arithmetic, compound expressions and order of operations 
             * Multiplication and division are done firat. left to right 
             * addition and subtraction are done last, left to right
             */

            int arithmetic1; // declaring the variable arithmetic1/
            arithmetic1 = 9 - 1; // assigning a value to arithmetic1. using some math
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3; // another assignment 
            Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; // delcaring arithmetic2 and assigning a vlaue to arithmetic2 all at once
            Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2; //assigning a second value to arithmetic2
            Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

            //use multiple sets of parenthesis to group operations 
            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");

            /* compound assignment operator */
            int compoundAssignmentOperator = 0;
            compoundAssignmentOperator += 5;
            compoundAssignmentOperator -= 2;
            compoundAssignmentOperator *= 4;
            compoundAssignmentOperator /= 2;
            compoundAssignmentOperator %= 2;
            int incrementDecrementOperators = 0;
            incrementDecrementOperators++;
            incrementDecrementOperators--;

            Console.WriteLine("**************************************************");
            Console.Write("What is you name, human? ");
            string userName = Console.ReadLine();

            Console.WriteLine("press any keywhen you're ready to begin.");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Hello World!";

            Console.Beep(440, 1000);




        }

    }

}