// See https://aka.ms/new-console-template for more information
using Equation;

Console.WriteLine("Введите коэффициенты квадратного кравнения");

Console.Write("A = ");
double a;
a = Convert.ToDouble(Console.ReadLine());

Console.Write("B = ");
double b;
b = Convert.ToDouble(Console.ReadLine());

Console.Write("C = ");
double c;
c = Convert.ToDouble(Console.ReadLine());

string answer = Solution.SolveEquation(a, b, c);

Console.WriteLine(answer);
