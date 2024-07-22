using _02_FactoryMethodPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethodPattern.Factory
{
    public class BYD_Tang_Factory : IBYD_Factory
    {
        public BYD CreateBYDCar()
        {
            return new BYD_Tang();
        }
    }
}
