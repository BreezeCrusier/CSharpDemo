using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTest
{
    class Program
    {
        static void Main(string[] args)
        {            
            // 这里将原数组转为列表的原因是数组没有获得元素索引的方法
            List<string> characters = 
                new List<string> { "Neptune", "Noire", "Blanc", "Vert" };

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // ForEach 方法可以遍历迭代器创建线程并执行
            Parallel.ForEach(characters, 
                i => SayHello(characters.IndexOf(i), i));

            Console.ReadKey();
        }

        static void SayHello(int? num, string name)
        {            
            if (num == null)
                num = -1;

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor++;
                Console.WriteLine($"{name} says \"Hello world!\" on line {num} " +
                    $"at {DateTime.UtcNow} in color {(int)Console.ForegroundColor}...");
            }
        }
        
    }
}
