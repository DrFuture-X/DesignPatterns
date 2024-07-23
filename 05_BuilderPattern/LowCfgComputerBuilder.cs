using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BuilderPattern
{
    /// <summary>
    /// 具体的建造者类：负责进行产品部件的构建
    /// </summary>
    public class LowCfgComputerBuilder : IBuilder
    {
        private Computer computer = new Computer();
        public override void BuildCPU()
        {
            computer.AddPart("Corei3-10100 CPU");
        }

        public override void BuildMainboard()
        {
            computer.AddPart("B560低端主板");
        }

        public override void BuildMemoryBank()
        {
            computer.AddPart("8G内存条两根");
        }

        public override void BuildSDD()
        {
            computer.AddPart("512G固态硬盘");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
