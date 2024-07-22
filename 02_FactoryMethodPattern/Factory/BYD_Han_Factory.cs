using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_FactoryMethodPattern.Product;

namespace _02_FactoryMethodPattern.Factory
{
    public class BYD_Han_Factory : IBYD_Factory
    {
        public BYD CreateBYDCar()
        {
            return new BYD_Han();
        }
    }
}
