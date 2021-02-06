using System;

namespace DiscardsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vec = new Vector3(1, 2, 3);

            // 声明元组，并为其赋值
            (int, int, int) k = (1, 2, 3);
            // 弃元，在局部代码中使用下划线占位
            var (_, _, z) = vec.GetVectorTuple();

            Console.WriteLine(k.ToString());
            Console.WriteLine("The value of vector's z is {0}！", z);
        }
    }

    struct Vector3
    {
        int x, y, z;

        public Vector3(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public (int x,int y, int z) GetVectorTuple()
        {
            return (this.x, this.y, this.z);
        }
    }
}
