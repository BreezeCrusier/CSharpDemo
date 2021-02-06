using System;

namespace WhenSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLottery();
            Console.ReadKey();
        }

        static void GetLottery()
        {
            Console.WriteLine("抽个奖吧，兄弟！");

            int x;
            string input = Console.ReadLine();
            bool isLegal = int.TryParse(input, out x);
            if (!isLegal)
            {
                GetLottery();
                return;
            }
                
            switch (x)
            {
                case 1:
                    Console.WriteLine("好耶！您中奖了嘿！");
                    break;
                case int y when y > 1 && y < 6:     // 这里的y是一个用于接受x值的的临时变量
                    Console.WriteLine("没抽到！");
                    break;
                case int y when y >= 6 && y <= 10:
                    Console.WriteLine("恭喜您，安慰奖，建议再来一次！");
                    GetLottery();
                    break;
                default:
                    Console.WriteLine("别整活儿，兄弟！");
                    return;
            }
                
        }
    }
}
