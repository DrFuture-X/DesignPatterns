using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BuilderPattern
{
    /// <summary>
    /// 产品类 Protect
    /// </summary>
    public class Computer
    {
        List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("----产品创建----");
            foreach (string part in parts)
            {
                Console.WriteLine("零件--" + part);
            }
            Console.WriteLine("----产品创建完成----");
        }
    }
}
