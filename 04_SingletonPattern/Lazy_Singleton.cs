using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonPattern
{
    /// <summary>
    /// 饿汉式
    /// 优点：即用即加载，节省内存
    /// 缺点：线程不安全
    /// </summary>
    public class Lazy_Singleton
    {
        // 类加载时，先不自动创建单例, 即将单例的引用先赋值为 Null
        private static Lazy_Singleton instance = null;

        //私有，保证其他类无法实例化单例类对象
        private Lazy_Singleton() { }

        //需要时才手动调用 newInstance()创建单例
        public static Lazy_Singleton GetInstance()
        {
            // 先判断单例是否为空，以避免重复创建
            if (instance == null)
            {
                instance = new Lazy_Singleton();
            }
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("懒汉式单例加载");
        }
    }
}
