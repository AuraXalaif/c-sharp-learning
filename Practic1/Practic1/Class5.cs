using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class5
    {
        // Клас Logger
        class Logger
        {
            public Action<string> LogHandler;

            public void Log(string message)
            {
                LogHandler?.Invoke(message);
            }
        }

        public static void Run()
        {
            Logger logger = new Logger();

            // Спочатку логування у консоль
            logger.LogHandler = msg => Console.WriteLine("Console: " + msg);
            logger.Log("First message");

            // Змінюємо логіку «на льоту» — тепер повідомлення у верхньому регістрі
            logger.LogHandler = msg => Console.WriteLine(msg.ToUpper());
            logger.Log("Second message");
        }
    }
}
