using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SampleFactoryPattern
{
    public class BYD_Han : BYD
    {
        public BYD_Han() : base() 
        { 
        }

        public override void GetCar()
        {
            Console.WriteLine("制造比亚迪汉");
        }
    }
}
