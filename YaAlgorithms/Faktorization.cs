using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    public class Faktorization
    {
        public static List<int> Do(int number)
        {
            var res = new List<int>();
            int point = 2;
            while (point <= number/2)
            {
                if (number % point == 0) 
                {
                    res.Add(point);
                    number = number / point;
                    point = 2;
                }
                else point++;
            }
            res.Add(number);
            return res;
        }
    }
}
