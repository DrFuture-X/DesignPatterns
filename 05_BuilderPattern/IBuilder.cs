using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BuilderPattern
{
    /// <summary>
    /// 抽象建造者类，确定产品的部件，并声明一个得到具体产品的Get方法。
    /// 指挥者将客户创建产品的需求划分为各个部件的建造请求（Builder）。
    /// </summary>
    public abstract class IBuilder
    {
        public abstract void BuildCPU();
        public abstract void BuildMainboard();
        public abstract void BuildSDD();
        public abstract void BuildMemoryBank();

        public abstract Computer GetComputer();
    }
}
