using System;

namespace ParamsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 10;
            int num3 = 100;
            int num4 = 1000;
            int num5 = 10000;
            int num6 = 100000;

            Add(num1,num2,num3,num4,num5,num6);

            Console.ReadKey();
        }

        // 传入的第一个参数将被省略，而后续的参数作为数组
        static void Add(int omitted, params int[] ints)
        {
            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine($"First number {omitted} is omitted.");
            Console.WriteLine($"What left sums up is {sum}!");
        }
    }
}
