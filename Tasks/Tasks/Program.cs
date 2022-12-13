using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 4;
            //int quvvet = 4;
            //int result = 1;

            //for (int i = 0; i < quvvet; i++)
            //{
            //    result *= num;
            //}

            //Console.WriteLine(result);
            Console.WriteLine("nece eded olacaq?");
            var countStr = Console.ReadLine();
            var count = Convert.ToInt32(countStr);
            int[] nums= new int[count];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin:");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                nums[i] = number;
                
            }
            var result = FindBiggest(nums);
            Console.WriteLine("result: "+result);
        }


        //- Verilmis ededi verilmis quvvete yukselden metod
        static int Pow(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }

        //Verilmis 3 ededden en boyuyunu tapan metod
        static int FindBiggest(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else if (num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }


        }

        //Verilmis ededler siyahisindaki en boyuk ededi tapan metod

        static int FindBiggest(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }


        //Verilmis say qeder ededler daxil edilir ve onlar arasindan enboyuyu console penceresinde gosterilir

    }
}
