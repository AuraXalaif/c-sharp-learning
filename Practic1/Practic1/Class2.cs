using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic1
{
    internal class Class2
    {
        delegate void notificationHandler(string message);

        static void SendEmail(string message) => Console.WriteLine("Email: " + message);
        static void SendSMS(string message) => Console.WriteLine("SMS: " + message);
        public static void Run()
        {
            notificationHandler handler = SendEmail;
            handler += SendSMS;
            handler("Hello Delegates!");
        }
    }
}
