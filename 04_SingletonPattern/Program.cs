namespace _04_SingletonPattern
{
    /// <summary>
    /// 单例模式：实现1个类只有1个实例化对象，即提供一个全局访问点，保证1个类只有1个对象，降低对象之间的耦合度
    /// 优点：
    ///     提供了对对外唯一实例的受控访问；
    ///     由于在系统内存中只存在一个对象，因此可以节约系统资源，对于一些需要频繁创建和销毁的对象单例模式无疑可以提高系统的性能；
    ///     可以根据实际情况需要，在单例模式的基础上扩展做出双例模式，多例模式；
    /// 缺点：
    ///     单例类的职责过重，里面的代码可能会过于复杂，在一定程度上违背了“单一职责原则”。
    ///     如果实例化的对象长时间不被利用，会被系统认为是垃圾而被回收，这将导致对象状态的丢失
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------");
            Eager_Singleton.GetInstance().Show();
            Console.WriteLine("----------");
            Lazy_Singleton.GetInstance().Show();
            Console.WriteLine("----------");
            Lazy_Singleton_DoubleCheckLocking.GetInstance().Show();
            Console.WriteLine("----------");
            Lazy_Singleton_Synchronized.GetInstance().Show();
        }
    }
}
