﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethodPattern.Product
{
    public class BYD_Qin : BYD
    {
        public BYD_Qin() : base()
        {
        }

        public override void GetCar()
        {
            Console.WriteLine("制造比亚迪秦");
        }
    }
}
