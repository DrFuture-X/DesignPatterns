using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonPattern
{
    /// <summary>
    /// 饿汉式改进：同步锁
    /// 原理：使用同步锁锁住创建单例的方法，防止多个线程同时调用，从而避免造成单例被多次创建。
    ///       若该段代码已在1个线程中运行，另外1个线程试图运行该块代码，则 会被阻塞而一直等待
    /// 优点：即用即加载，节省内存，线程安全
    /// 缺点：每次访问都要进行线程同步（即 调用锁)，造成过多的同步开销（加锁 = 耗时、耗能）
    /// </summary>
    public class Lazy_Singleton_Synchronized
    {
        // 类加载时，先不自动创建单例, 即将单例的引用先赋值为 Null
        private static Lazy_Singleton_Synchronized instance = null;
        private static readonly object syncRoot = new object();

        //私有，保证其他类无法实例化单例类对象
        private Lazy_Singleton_Synchronized() { }

        //需要时才手动调用 newInstance()创建单例
        public static Lazy_Singleton_Synchronized GetInstance()
        {
            // 加入同步锁
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new Lazy_Singleton_Synchronized();
                }
            }
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("懒汉式单例加载--同步锁");
        }
    }
}
