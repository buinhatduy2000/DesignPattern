using System;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var mess1 = new NotificationData();

             _ = new GmailNotifier(mess1);

            mess1.SetDay(DateTime.Now);
            mess1.SetContent("Your flight has been canceled");
            mess1.SetDescription("Due to weather issue your flight will be canceled, sorry for the inconvenience");

            Console.ReadKey();


        }
    }
}
