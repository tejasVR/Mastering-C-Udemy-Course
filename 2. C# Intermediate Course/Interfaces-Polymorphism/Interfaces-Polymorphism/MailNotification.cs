using System;

namespace Interfaces_Polymorphism
{
    public class MailNotification : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
