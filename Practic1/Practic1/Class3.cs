using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class3
    {
        // Делегат, який приймає число і повертає bool
        delegate bool FilterPredicate(int number);

        // Метод для фільтрації масиву
        static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (var n in numbers)
            {
                if (predicate(n))
                    Console.WriteLine(n);
            }
        }

        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers:");
            FilterArray(numbers, n => n % 2 == 0);

            Console.WriteLine("Numbers > 5:");
            FilterArray(numbers, n => n > 5);

            Console.WriteLine("Odd numbers:");
            FilterArray(numbers, n => n % 2 != 0);
        }
    }
}