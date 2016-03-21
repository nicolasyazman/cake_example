using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeExample
{
    public class MathTools
    {
        public int Factorielle(int value)
        {
            if (value < 0)
                return 0;
            if (value == 0 || value == 1)
                return 1;
            int res = 1;
            for (int i = 1; i <= value; i++)
            {
                res *= i;
            }
            return res;
     
        }
    }
}
