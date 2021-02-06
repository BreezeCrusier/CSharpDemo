using System;
using System.Collections;
using System.Collections.Generic;

namespace ListRemoveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "A", "B", "V", "D", "E", "F", "G", "X", "I", "J" };
            List<TestClass> li = new List<TestClass>();

            for (int i = 0; i < 10; i++)
            {
                li.Add(new TestClass { num = i });
            }

            Console.WriteLine(li.Count);
            var ts = new ArrayList();

            for (int i = 0; i < li.Count; i++)
            {
                var t = li[i];
                
                if(t.num%3==0)
                {
                    ts.Add(t);
                }
            }

            foreach (var item in ts)
            {
                li.Remove((TestClass)item);
            }

            Console.WriteLine(li.Count);

            foreach (var item in li)
            {
                
                Console.WriteLine(item.num);
            }

            Console.ReadKey();
        }
    }

    class TestClass
    {
        public int num;
    }
}
