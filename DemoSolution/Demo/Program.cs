using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //Console.Write("Hello World! ");
            //Console.WriteLine("Salam");


            //bool isMarried = true;

            //byte converted = Convert.ToByte(isMarried);

            //Console.WriteLine("Converted bool = " + converted);

            //byte myByte = 255;
            //sbyte mySbyte = -128;

            //int newVariable = Convert.ToInt16(myByte);
            //string newString = newVariable.ToString();
            //newString = Convert.ToString(newVariable);

            //char LetterA = 'A';
            //char LetterSmallA = 'a';

            //short shortValue = 31222;

            //int newInt = 2147483647;

            //long newLong = 1234567891325;

            //float newFloat = 5.5F;


            //sbyte degree = -11;

            //uint degreeInt = (uint)degree;

            //Console.WriteLine("degree: " + degreeInt);


            Console.WriteLine("Please enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Sum: " + sum);


            Console.ReadLine();



        }
    }
}
