using System;

namespace VladDemo
{
    class Program
    {
        static void Main()
        {
            SomeFunction();
            Console.WriteLine("Hello World!");
        }

        [Test]
        [return:Test]
        static void SomeFunction()
        {

        }
    }

    class TestAttribute : Attribute
    {
        public TestAttribute()
        {
            // Some statements...
        }
    }
}
