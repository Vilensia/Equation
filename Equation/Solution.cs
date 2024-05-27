using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public static class Solution
    {
        public static string SolveEquation(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;

            if (a == 0)
            {
                x1 = -c / b;
                return "Не квадратное уравнение, x = " + x1.ToString("0.00");
            }

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                return "Уравнение не имеет решений";
            }

            if (d == 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                return "Уравнение имеет два одинаковых корня x1 = x2 = " + x1.ToString("0.00");
            }

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            return "Уранение имеет корни x1 = " 
                      + x1.ToString("0.00") + " x2= " + x2.ToString("0.00");
        }

    }
}
