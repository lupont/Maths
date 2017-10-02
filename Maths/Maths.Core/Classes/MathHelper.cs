using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths.Core
{
    public static class MathHelper
    {
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
    }
}
