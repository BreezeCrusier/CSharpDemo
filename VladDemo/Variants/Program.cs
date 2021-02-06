using System;

namespace Variants
{
    class Program
    {
        static void Main(string[] args)
        {
            // 声明引用类型变量t1和t2并为其赋值：
            var t1 = new TestClass();
            t1.num = 1;
            var t2 = new TestClass();
            t2.num = 1;

            //Console.WriteLine("为t1和t2分别分配实例对象：");
            //ShowValue(t1, t2);

            // 将t1中储存的堆地址赋值给t2，此时t2与t1中储存的对地址相同，二者指向堆上的同一块内存，也就是同一个实例对象
            t2 = t1;

            //Console.WriteLine("当t2指向的堆内存与t1相同后：");
            //ShowValue(t1, t2);

            //// 改变t2指向的实例对象的属性值num，会发现t1指向实例对象的属性值也发生了改变，因为两者所指向的实例对象是同一对象
            //t2.num = 5;

            //Console.WriteLine("当t1与t2指向同一个实例对象，改变t2的值：");
            //ShowValue(t1, t2);

            Console.ReadKey();
        }

        static void ShowValue(TestClass t1,TestClass t2)
        {
            Console.WriteLine("t1's value is " + t1.num.ToString() + " and t2's value is " + t2.num.ToString());
        }
    }

    class TestClass
    {
        public int num { get; set; }
    }

}
