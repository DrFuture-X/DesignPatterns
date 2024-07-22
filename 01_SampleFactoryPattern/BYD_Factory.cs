using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SampleFactoryPattern
{
    public class BYD_Factory
    {
        public static BYD CreateBYDCar(CarName carName) 
        {
            BYD byd = null;
            switch (carName)
            {
                case CarName.秦:
                    byd = new BYD_Qin();
                    break;
                case CarName.汉:
                    byd = new BYD_Han();
                    break;
                case CarName.唐:
                    byd = new BYD_Tang();
                    break;
                default:
                    byd = new BYD_New();
                    break;
            }
            return byd;
        }
    }
}
