using _03_AbstractFactoryPattern.Battery;
using _03_AbstractFactoryPattern.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactoryPattern.Factory
{
    public class Factory_Han : IFactory
    {
        public IBattery CreateBattery()
        {
            return new Battery_Han();
        }

        public IEngine CreateEngine()
        {
            return new Engine_Han();
        }
    }
}
