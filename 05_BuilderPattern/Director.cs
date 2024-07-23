using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BuilderPattern
{
    /// <summary>
    /// 具体的指挥者类，在这里组装并生成产品，直接和客户（Client）进行需求沟通
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 建造
        /// </summary>
        public void Construct(IBuilder builder)
        {
            builder.BuildMainboard();
            builder.BuildCPU();
            builder.BuildSDD();
            builder.BuildMemoryBank();
        }
    }
}
