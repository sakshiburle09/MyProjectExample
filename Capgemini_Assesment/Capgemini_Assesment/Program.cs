using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    public class CustomNotification
    {
        public delegate void Notify();

        public event Notify CustomNotificationEvent;

        public string Notification { get; private set; }

        void OnSubscribe()
        {
            Notification = "Subscribed to custom notification";
           
        }

        void OnUnSubscribe()
        {
            Notification = "Unsubscribed to custom notification";
        }

        public void CustomNotificationSubscription(bool notify)
        {
            if (notify)
            {
                CustomNotificationEvent += OnSubscribe;
                OnSubscribe();
            }
            else
            {
                CustomNotificationEvent += OnUnSubscribe;
                OnUnSubscribe();
            }

            CustomNotificationEvent -= OnSubscribe;
            CustomNotificationEvent -= OnUnSubscribe;
        }

    }
    class program
    {
        public static void Main(string[] args)
        {
            var customNotification = new CustomNotification();
            customNotification.CustomNotificationSubscription(true);
            Console.WriteLine(customNotification.Notification);
            customNotification.CustomNotificationSubscription(false);
            Console.WriteLine(customNotification.Notification);

        }
    }
}
