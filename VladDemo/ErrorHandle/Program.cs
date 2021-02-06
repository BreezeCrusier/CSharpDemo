using System;

namespace ErrorHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            try
            {
                int x = int.Parse(input);
                Console.WriteLine("您的输入数字为{0}", x);
            }
            catch(Exception e) when (!e.Message.Contains("Input"))
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
