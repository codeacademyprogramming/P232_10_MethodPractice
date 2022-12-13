using System;

namespace _13122022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================taks 1=======================");
            Console.WriteLine("Ededi daxil edin:");
            var num = GetInt();

            var result = Square(num);

            Console.WriteLine(result);

            Console.WriteLine("==================taks 2=======================");

            Console.WriteLine("yazini daxil edin:");
            string word = Console.ReadLine();

            var checkHasA = HasA(word);

            Console.WriteLine(checkHasA);


            Console.WriteLine("\n==================taks 3=======================");

            var elcin = GetInt();

            Console.WriteLine(SumOfDigits(elcin));
        }

        static int Square(int num)
        {
            return num * num;
        }

        static int GetInt()
        {
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            return num;
        }

        static bool HasA(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    hasA = true;
                    break;  
                }
            }

            return hasA;    
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n = (n - n % 10) / 10;
            }

            return sum;

        }
	
        static int Avg(int num1,int num2,int num3,int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }



    }
}
