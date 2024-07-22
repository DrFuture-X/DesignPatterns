using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_AbstractFactoryPattern.Battery;
using _03_AbstractFactoryPattern.Engine;

namespace _03_AbstractFactoryPattern.Factory
{
    public interface IFactory
    {
        //制造发动机
        public IEngine CreateEngine();
        //制造电池
        public IBattery CreateBattery();
    }
}
