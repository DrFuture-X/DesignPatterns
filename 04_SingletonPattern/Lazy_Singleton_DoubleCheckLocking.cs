using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonPattern
{
    /// <summary>
    /// 饿汉式改进：双重锁定
    /// 优点：即用即加载，节省内存，线程安全
    /// 缺点：实现复杂 = 多种判断，易出错
    /// </summary>
    public class Lazy_Singleton_DoubleCheckLocking
    {
        // 类加载时，先不自动创建单例, 即将单例的引用先赋值为 Null
        private static Lazy_Singleton_DoubleCheckLocking instance = null;
        private static readonly object syncRoot = new object();

        //私有，保证其他类无法实例化单例类对象
        private Lazy_Singleton_DoubleCheckLocking() { }

        //需要时才手动调用 newInstance() 创建单例
        public static Lazy_Singleton_DoubleCheckLocking GetInstance()
        {
            //双重锁定
            //锁1：先判断单例是否为空，不存在再加锁
            if (instance == null)
            {
                lock (syncRoot)
                {
                    //锁2：如果为空，进行实例化
                    if (instance == null)
                    {
                        instance = new Lazy_Singleton_DoubleCheckLocking();
                    }
                }
            }
            return instance;
        }
        public void Show()
        {
            Console.WriteLine("懒汉式单例加载--双重锁定");
        }
    }
}
