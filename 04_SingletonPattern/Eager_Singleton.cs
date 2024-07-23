using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingletonPattern
{
    /// <summary>
    /// 饿汉式
    /// 优点：线程安全
    /// 缺点：没有使用该单例对象，该对象就被加载到了内存，会造成内存的浪费
    /// </summary>
    public class Eager_Singleton
    {
        //加载该类时，单例就会自动被创建
        private static Eager_Singleton instance = new Eager_Singleton();

        //私有，保证其他类无法实例化单例类对象
        private Eager_Singleton() { }

        //通过调用静态方法获得创建的单例
        public static Eager_Singleton GetInstance()
        {
            return instance;
        }

        public void Show()
        {
            Console.WriteLine("饿汉式单例加载");
        }
    }
}
