﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethodPattern.Product
{
    public class BYD_New : BYD
    {
        public BYD_New() : base()
        {
        }

        public override void GetCar()
        {
            Console.WriteLine("暂时没有这个车");
        }
    }
}
