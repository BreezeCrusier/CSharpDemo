using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = GetNumAsync();
            Thread.Sleep(1000);
            Console.WriteLine("好耶！");
            // int x = await t;
            // Console.WriteLine("The number is {0}",x);
            Console.ReadKey();
        }

        static async Task ShowNumberAsync()
        {
            Console.WriteLine("The show has begun!");
            int num = await GetNumAsync();
            Console.WriteLine("We get your number:{0}", num);
           
        }

        static async Task<int> GetNumAsync()
        {
            Console.WriteLine("Begin getting number!");
            int num = await Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Ready!");
                Thread.Sleep(5000);
                return new Random().Next(1, 11);
            });
            Console.WriteLine("Getting number, please hold...");
            return num;
        }


        static async Task ShowAsync()
        {
            Console.WriteLine("The show has begun!");
            await GetAsync();
            Console.WriteLine("We didn't get your number!");

        }

        static async Task GetAsync()
        {
            Console.WriteLine("Begin getting number!");
            await Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Ready!");
                Thread.Sleep(5000);
                Console.WriteLine("Enough sleep!");
            });
            Console.WriteLine("Getting number, please hold...");
            
        }
    }
}
