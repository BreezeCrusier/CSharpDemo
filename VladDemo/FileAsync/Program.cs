using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string data;

            using(FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\a.txt", FileMode.OpenOrCreate))
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
                byte[] buffer = new byte[100000];
                Task<int> task = fs.ReadAsync(buffer, 0, 10);
                data = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(data);
                Thread.Sleep(1000);
                int len = await task;
                data = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(data);
            }
            


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
