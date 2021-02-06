using System;

namespace ReferenceParametres
{
    class Program
    {
        static void Main(string[] args)
        {
            Host h1 = new Host { name = "犬山玉姬" };
            Host h2 = new Host { name = "海苔男妈妈" };

            ChangeHost(ref h1, h2);

            Console.WriteLine($"宿主1是：{h1.name}，宿主2是{h2.name}");

            h1.name = "猫山玉姬";

            Console.WriteLine($"宿主1是：{h1.name}，宿主2是{h2.name}");

            //int x = 100;
            //int y = 200;
            //int sum = AddAndAddPlus(ref x, ref y);

            //Console.WriteLine($"{x} + {y} = " + sum.ToString());
            Console.ReadKey();
        }

        static int AddAndAddPlus(ref int a,ref int b)
        {
            a++;
            b++;
            return a + b;
        }

        static void ChangeHost(ref Host host, Host newHost)
        {
            host = newHost;
        }

        class Host
        {
            public string name;
        }
    }
}
