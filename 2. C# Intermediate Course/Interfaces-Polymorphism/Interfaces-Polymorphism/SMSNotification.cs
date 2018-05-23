using System;

namespace Interfaces_Polymorphism
{
    public class SMSNotification : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}
