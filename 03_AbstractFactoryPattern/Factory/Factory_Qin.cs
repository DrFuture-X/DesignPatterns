using _03_AbstractFactoryPattern.Battery;
using _03_AbstractFactoryPattern.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactoryPattern.Factory
{
    public class Factory_Qin : IFactory
    {
        public IBattery CreateBattery()
        {
            return new Battery_Qin();
        }

        public IEngine CreateEngine()
        {
            return new Engine_Qin();
        }
    }
}
