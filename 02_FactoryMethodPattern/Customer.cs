using _02_FactoryMethodPattern.Factory;
using _02_FactoryMethodPattern.Product;

namespace _02_FactoryMethodPattern
{
    /* 工厂方法模式
     * 使客户端与实际的对象的建造过程分开，客户端直接使用对象
     * 抽象工厂角色：具体工厂必须实现的接口或必须实现的父类，由抽象类或接口来实现
     * 具体工厂角色：具体的业务逻辑的代码，由应用程序调用以创建具体的产品的对象
     * 抽象产品角色：具体产品必须实现的父类，由抽象类或普通父类来实现
     * 具体产品角色：具体工厂所创建的对象
     * 优点：符合开闭原则；
     * 缺点：当产品太多时，会创建很多的类
     */
    internal class Customer
    {
        static void Main(string[] args)
        {
            IBYD_Factory qinFactory = new  BYD_Qin_Factory();
            BYD qin = qinFactory.CreateBYDCar();
            qin.GetCar();

            IBYD_Factory hanFactory = new BYD_Han_Factory();
            BYD han = hanFactory.CreateBYDCar();
            han.GetCar();
        }
    }
}
