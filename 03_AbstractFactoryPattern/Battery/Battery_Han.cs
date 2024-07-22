using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AbstractFactoryPattern.Battery
{
    public class Battery_Han : IBattery
    {
        public void GetBattery()
        {
            Console.WriteLine("生产汉的电池");
        }
    }
}
