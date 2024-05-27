using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Equation
{

    /*
     * need donload nuget pac
     * 1. NUnit3TestAdapter
     * 2. NUnit
     * 3. NUnitConsoleRunner
     * 4. Microsoft.Net.Test.Sdk
     * 
     * Before run tests build the project and open tests explorer 
     */
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CheckNonQuadraticEquation()
        {
            double a = 0;
            double b = 1;
            double c = 2;

            double x = -c / b;

            string expected  = "Не квадратное уравнение, x = " + x.ToString("0.00");
            string actual = Solution.SolveEquation(a, b, c);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void CheckNonSolutionQuadraticEquation()
        {
            double a = 8;
            double b = 1;
            double c = 12;

            string expected = "Уравнение не имеет решений";
            string actual = Solution.SolveEquation(a, b, c);

            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void CheckOneSolutionQuadraticEquation()
        {
            double a = 1;
            double b = -2;
            double c = 1;

            double d = b * b - 4 * a * c;

            double x = (-b + Math.Sqrt(d)) / (2 * a);
           
            string expected = "Уравнение имеет два одинаковых корня x1 = x2 = " + x.ToString("0.00");
            string actual = Solution.SolveEquation(a, b, c);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void CheckTwoSolutionQuadraticEquation()
        {
            double a = 1;
            double b = -5;
            double c = 6;

            double d = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);

            string expected = "Уранение имеет корни x1 = "
                      + x1.ToString("0.00") + " x2= " + x2.ToString("0.00");
            string actual = Solution.SolveEquation(a, b, c);

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
