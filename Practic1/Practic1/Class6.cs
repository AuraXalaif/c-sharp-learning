using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class6
    {
        // Делегат, який приймає рядок і повертає bool
        delegate bool Validator(string input);

        // Метод, який повертає делегат-замикання
        static Validator GetValidator(int minLength)
        {
            return s => s.Length >= minLength;
        }

        public static void Run()
        {
            // Створюємо два валідатори
            var passwordValidator = GetValidator(8); // мінімум 8 символів
            var loginValidator = GetValidator(3);    // мінімум 3 символи

            // Перевіряємо приклади
            Console.WriteLine("Password '12345678' valid? " + passwordValidator("12345678"));
            Console.WriteLine("Password '1234' valid? " + passwordValidator("1234"));

            Console.WriteLine("Login 'ab' valid? " + loginValidator("ab"));
            Console.WriteLine("Login 'alex' valid? " + loginValidator("alex"));
        }
    }
}
