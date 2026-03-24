using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class1
    {
        delegate double MathOperation(double a, double b);
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
        public static void Run()
        {
            MathOperation op;

            op = Add;
            Console.WriteLine("Add: " + op(10, 5));

            op = Subtract;
            Console.WriteLine("Subtract: " + op(10, 5));

            op = Multiply;
            Console.WriteLine("Multiply: " + op(10, 5));

            op = Divide;
            Console.WriteLine("Divide: " + op(10, 5));
        }
    }
}