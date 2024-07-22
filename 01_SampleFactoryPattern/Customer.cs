namespace _01_SampleFactoryPattern
{
    /* 简单工厂模式
     * 使客户端与实际的对象的建造过程分开，客户端直接使用对象
     * 工厂类角色：模式核心，含有逻辑判断代码，用来创建具体产品
     * 抽象产品角色：具体产品必须实现的父类，由抽象类或普通父类来实现
     * 具体产品角色：工厂类所创建的对象
     * 优点：对于产品部分（能够生产什么车）来说，符合开闭原则；
     * 缺点：对于工厂方法来说不太理想，以为每增加一种产品（新型车），
     * 都要在工厂类中创建新的业务逻辑，即增加新的case，违反开闭原则
     */
    public class Customer
    {
        public static void Main(string[] args)
        {
            BYD byd = BYD_Factory.CreateBYDCar(CarName.秦);
            byd.GetCar();
        }
    }
}
