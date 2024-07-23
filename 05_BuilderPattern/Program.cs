namespace _05_BuilderPattern
{
    /// <summary>
    /// 建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示,
    ///             使用户在不知道对象的建造过程和细节的情况下就可以直接创建复杂的对象。
    /// 优点：易于解耦:
    ///       将产品本身与产品创建过程进行解耦，可以使用相同的创建过程来得到不同的产品。也就说细节依赖抽象。
    ///       易于精确控制对象的创建:
    ///       将复杂产品的创建步骤分解在不同的方法中，使得创建过程更加清晰
    ///       易于拓展:
    ///       增加新的具体建造者无需修改原有类库的代码，易于拓展，符合“开闭原则“。
    /// 缺点：建造者模式所创建的产品一般具有较多的共同点，其组成部分相似；如果产品之间的差异性很大，则不适合使用建造者模式，因此其使用范围受到一定的限制。
    ///       如果产品的内部变化复杂，可能会导致需要定义很多具体建造者类来实现这种变化，导致系统变得很庞大。
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //我来买电脑，找到了店老板和装机人员，我钱多，要一台高配电脑
            Director director = new Director();
            IBuilder builder1 = new HighCfgComputerBuilder();
            //确定需求后，装机
            director.Construct(builder1);
            //装机完成，进行展示
            Computer computer = builder1.GetComputer();
            computer.Show();
        }
    }
}
