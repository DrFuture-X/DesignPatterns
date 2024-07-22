using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactoryPattern.Engine
{
    public class Engine_Qin : IEngine
    {
        public void GetEngine()
        {
            Console.WriteLine("生产秦的引擎");
        }
    }
}
