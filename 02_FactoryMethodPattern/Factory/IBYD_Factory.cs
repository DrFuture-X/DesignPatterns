using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_FactoryMethodPattern.Product;

namespace _02_FactoryMethodPattern.Factory
{
    /*
     * 工厂接口，实现一种型号只有一个工厂生产
     */
    public interface IBYD_Factory
    {
        BYD CreateBYDCar();
    }
}
