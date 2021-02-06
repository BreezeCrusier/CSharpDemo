using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionParametres
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 110, 120, 130, 140, 150 };
            bool isAllGreaterThanHundred = ints.All(i => i > 10);

            Console.WriteLine($"Is each element in ints greater than 100? \n" +
                $"Result: {isAllGreaterThanHundred}...");
            Console.ReadKey();
        }
    }

    // 声明静态类型，使用Extension扩展名做后缀
    static class DoubleExtension
    {
        // 使用this关键字修饰添加扩展方法的目标类型，这里是double
        public static double Round(this double input,int digits)
        {
            return Math.Round(input, digits);
        }
    }
}
