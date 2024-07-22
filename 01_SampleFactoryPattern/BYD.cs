using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SampleFactoryPattern
{
    public enum CarName
    {
        秦,
        汉,
        唐,
        宋,
        元,
        新
    }

    public abstract class BYD
    {
        public BYD() { }
        public abstract void GetCar();
    }
}
