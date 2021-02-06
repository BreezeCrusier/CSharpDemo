using System;
using System.IO;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tc1 = new TestClass();
            Type t = tc1.GetType();

            // 将类型信息Type类的实例直接转化为字符串将得到它的完全限定名（命名空间+类型名）
            Console.WriteLine("t's type is " + t.ToString());

            tc1.PrintTypeNames();
            

            Console.ReadLine();
        }
    }


    class TestClass
    {
        public void PrintTypeNames()
        {
            // 从本地载入dll文件
            Assembly assembly = Assembly.LoadFrom(Directory.GetCurrentDirectory() + @"\NightEdgeFramework.dll");
            var types = assembly.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.FullName);
            }
        }
    }
}
