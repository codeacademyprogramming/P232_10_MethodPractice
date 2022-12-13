using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = Sum(34, 10,10);
            var resultDbl = Sum(10d, 45);
            result = Sum(num2:40,num1:55);

            //byte[] numbers = new byte[4] {34,10,34,50};
            //numbers = new byte[] { 45, 55, 200, 201, 100 };
            byte[] numbers = { 34, 10,15,44};


            numbers[0] = 45;
            numbers[1] = 30;
            numbers[2] = 10;
            numbers[3] = 55;

            Console.WriteLine($"Numbers sum: {Sum(numbers)}");

            int nameCount = 10;

            string[] names = new string[nameCount];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}-ci adi daxil et");
                names[i] = Console.ReadLine();
            }


            Console.WriteLine("adlar:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Sum(double num1,double num2)
        {
            return num1 + num2;
        }

        static int Sum(int num1,int num2,int num3=0)
        {
            return num1 + num2 + num3;
        }

        static int Sum(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
        static int Sum(byte[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
