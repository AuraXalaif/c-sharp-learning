using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class4
    {
        public static void Run()
        {
            // Використання стандартного делегата Func<double, double, double>
            Func<double, double, double> operation = (a, b) => a + b;
            Console.WriteLine("Func Add: " + operation(10, 5));

            operation = (a, b) => a - b;
            Console.WriteLine("Func Subtract: " + operation(10, 5));

            operation = (a, b) => a * b;
            Console.WriteLine("Func Multiply: " + operation(10, 5));

            operation = (a, b) => b != 0 ? a / b : double.NaN;
            Console.WriteLine("Func Divide: " + operation(10, 5));

            // Список студентів
            var students = new List<string> { "Anna", "Andriy", "Bohdan", "Olena", "Oksana" };

            // Використання Predicate<string> для пошуку імен, які починаються на "A"
            var result = students.FindAll(name => name.StartsWith("A"));

            Console.WriteLine("Names starting with A:");
            foreach (var name in result)
                Console.WriteLine(name);
        }
    }
}