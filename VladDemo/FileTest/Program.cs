using System;
using System.Text;
using System.IO;

namespace FileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + @"/a.txt";
            string str;

            using (var fs = new FileStream(path, FileMode.Open))
            {
                /* 这里的形参是字节数组，为引用类型变量，它和实参buffer指向
                /* 同一个实例对象，因此通过形参改变的实例对象，就是通过实参
                /* buffer访问到的对象，字节数组实例对象直接被写入 */
                byte[] buffer = new byte[5 * 1024 * 1024];
                int len = fs.Read(buffer, 0, buffer.Length);
                str = Encoding.UTF8.GetString(buffer);
            }

            Console.WriteLine("文件a.txt的内容是：\n" + str);
            Console.ReadKey();
        }
    }
}
