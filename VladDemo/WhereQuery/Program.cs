using System;
using System.Linq;

namespace WhereQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 返回大于5的偶数的子集（可以不换行）
            var requestedNums =
                from num in nums
                where num >= 5
                where num % 2 == 0
                select num;
            // 这里检验偶数的表达式使用了一个静态方法
            var requestedNumsAno =
                from num in nums
                where num >= 5
                where IsEven(num)
                select num;

            foreach (var item in requestedNums)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();

            foreach (var item in requestedNumsAno)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();    // 这一行不写会在程序结束后出现意外现象

            Console.ReadKey();
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
    }
}
