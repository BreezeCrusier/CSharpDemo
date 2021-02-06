using System;

namespace NamedParametres
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用具名参数可以将令参数的位置发生改变
            ShowResume(age: 24, profession: "學生");
            Console.ReadKey();
        }

        static void ShowResume(string profession,int age)
        {
            Console.WriteLine($"{age}穢，是{profession}!");
        }
    }
}
