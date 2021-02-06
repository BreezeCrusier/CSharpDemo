using System;
using System.Reflection;

namespace AttributeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Flag[] flags = new Flag[10];

            // 先来的雪糕很好，后来的已经热化了
            for (int i = 0; i < flags.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        flags[i] = Flag.CoolAndGood;
                        break;
                    case 1:
                        flags[i] = Flag.CoolAndNotBad;
                        break;
                    default:
                        flags[i] = Flag.WarmAndBad;
                        break;
                }
            }

            for (int i = 0; i < flags.Length; i++)
            {
                Console.WriteLine($"The flag {i + 1} is " +
                    $"{flags[i].GetDescription()}...");
            }

            Console.ReadKey();
        }
    }

    // 这里的Flag用于标记雪糕品质
    enum Flag
    {
        [FlagTest("好耶！")]
        CoolAndGood = 0,
        [FlagTest("海星")]
        CoolAndNotBad = 1,
        // 将这个特性注释掉，则后面的项都是英文
        // [FlagTest("不！")]
        WarmAndBad = 2
    }

    class FlagTestAttribute : Attribute
    {
        private string _description;
        public FlagTestAttribute(string dsc)
        {
            this._description = dsc;
        }
        public string GetDescription()
        {
            return this._description;
        }
    }
    
    static class FlagExtension
    {
        public static string GetDescription(this Flag flag)
        {
            Type type = flag.GetType();
            // 获得枚举的字段成员，也就是每一个枚举项
            var fi = type.GetField(flag.ToString());   
            if (fi.IsDefined(typeof(FlagTestAttribute),true))
            {
                // 使用反射创建一个FlagTestAttribute的实例对象
                var flagAttr = (FlagTestAttribute)fi.GetCustomAttribute(
                    typeof(FlagTestAttribute), true);
                return flagAttr.GetDescription();
            }
            else
            {
                // 如果该枚举类型没有被属性修饰，直接返回枚举内容
                return flag.ToString();
            }
        }
    }

}
