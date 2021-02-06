using System;
using System.Linq;

namespace GroupLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass[] tests = new TestClass[10];
            for (int i = 0; i < tests.Length; i++)
            {
                tests[i] = new TestClass { num = i * 100 };
            }

            var groups =
                from test in tests
                group test by test.num % 200 == 0;

            foreach (var item in groups)
            {
                Console.WriteLine(item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine(g.num);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }

    class TestClass
    {
        public int num;
    }
}
