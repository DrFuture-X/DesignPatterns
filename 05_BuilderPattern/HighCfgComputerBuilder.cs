using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BuilderPattern
{
    /// <summary>
    /// 体的建造者类：负责进行产品部件的构建
    /// </summary>
    public class HighCfgComputerBuilder : IBuilder
    {
        private Computer computer = new Computer();
        public override void BuildCPU()
        {
            computer.AddPart("Corei7-14700K CPU");
        }

        public override void BuildMainboard()
        {
            computer.AddPart("Z790高端主板");
        }

        public override void BuildMemoryBank()
        {
            computer.AddPart("32G内存条两根");
        }

        public override void BuildSDD()
        {
            computer.AddPart("2T固态硬盘");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
