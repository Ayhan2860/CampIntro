using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;

            number1 = number2;

            number2 = 60;


            //Console.WriteLine(number1);
            //number1 = ? 


            int[] numbers1 = new int[] { 1, 2, 3, 4 };
            int[] numbers2 = new int[] { 10, 20, 30, 40 };

            numbers1 = numbers2;
            numbers2[0] = 999;

            //Console.WriteLine(numbers1[0]);

            //numbers1[0] = ? 
        }
    }
}
