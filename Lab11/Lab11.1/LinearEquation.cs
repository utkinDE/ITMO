using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    internal struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b == 0)
            {
                return "x - любоё число";
            }
            else if (b == 0)
            {
                return "x = 0";
            }
            else if (k == 0)
            {
                return "решений нет";
            }

            double x = -b / k;

            return "Решение уравнения, x = " + x;
        }
    }
}