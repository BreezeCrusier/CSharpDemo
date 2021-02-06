using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
               SomeFunc(out int a);
               Console.WriteLine($"{a}");
            }
           
        }

        static int SomeFunc(out int input)
        {
            input = new Random().Next(1, 11);
            return input;
        }
    }
}
