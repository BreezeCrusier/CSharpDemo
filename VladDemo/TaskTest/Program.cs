using System;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 10;
            //string name1 = "Kizuna_Ai";
            //string name2 = "Siri";

            //TaskFactory tf = Task.Factory;

            Task t = new Task(() => 
            {
                Console.WriteLine($"Task t begins at {DateTime.UtcNow}...");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("好耶！");
                Console.WriteLine($"Task t ends at {DateTime.UtcNow}...");

            });
            
            t.ContinueWith((Task) => 
            {
                Console.WriteLine($"Continuation begins at {DateTime.UtcNow}...");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("好耶！");
                Console.WriteLine($"Continuation ends at {DateTime.UtcNow}...");
            });

            t.Start();


            // Task.WaitAny(t);

            //tf.StartNew(() => { SayHello(count, name1, ConsoleColor.Red); });
            //tf.StartNew(() => { SayHello(count, name2, ConsoleColor.Green); });

            Console.ReadKey();
        }

        static void SayHello(int count, string name, ConsoleColor color)
        {            
            for (int i = 0; i < count; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{name} says\"Hello world!\" for {i + 1} times...");
            }
        } 
    }
}
