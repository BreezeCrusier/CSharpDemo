using System;

namespace Cargo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass t1 = new TestClass { num = 100 };
            object obj;
            obj = t1;

            t1.num = 300;

            TestClass t2 = (TestClass)obj;

            Console.WriteLine(t2.num.ToString());
            Console.ReadKey();
        }
    }
    
    class TestClass
    {
        public int num { get; set; }
    }
}
