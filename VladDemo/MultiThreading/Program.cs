using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ThreadWithReturn(() =>
            {
                Thread.Sleep(5000);
                return new Random().Next(1, 11);
            });

            var b = a.Invoke();
            Console.WriteLine(b);
            Console.WriteLine("Hello World!");
        }

        static Func<T> ThreadWithReturn<T>(Func<T> func)
        {
            T t = default(T);
            var thread = new Thread(() =>
            {
                Console.WriteLine("传入的函数开始执行！");
                t = func.Invoke();
            });
            thread.Start();

            return () =>
            {
                // 在thread线程为执行完成时阻塞
                // 当thread线程执行结束t才获得期望的值
                thread.Join();
                return t;
            };
        }
    }
}
