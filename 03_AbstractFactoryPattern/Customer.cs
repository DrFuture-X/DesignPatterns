using _03_AbstractFactoryPattern.Engine;
using _03_AbstractFactoryPattern.Battery;
using _03_AbstractFactoryPattern.Factory;

namespace _03_AbstractFactoryPattern
{
    /* 抽象工厂模式
     * 使客户端与实际的对象的建造过程分开，客户端直接使用对象
     * 每个工厂生产一个产品的所有子类产品
     * 优点：符合开闭原则；
     * 缺点：当产品太多时，会创建很多的类
     */
    public class Customer
    {
        static void Main(string[] args)
        {
            IFactory factoryHan = new Factory_Han();
            IBattery batteryHan = factoryHan.CreateBattery();
            batteryHan.GetBattery();
            IEngine engineHan = factoryHan.CreateEngine();
            engineHan.GetEngine();

            IFactory factoryQin = new Factory_Qin();
            IBattery batteryQin = factoryQin.CreateBattery();
            batteryQin.GetBattery();
            IEngine engineQin = factoryQin.CreateEngine();
            engineQin.GetEngine();
        }
    }
}
