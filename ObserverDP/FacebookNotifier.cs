﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    class FacebookNotifier: Observer
    {
        public FacebookNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.addObserver(this);
        }
        public override void Notify(object arg)
        {
            NotificationData notificationData = new NotificationData();

            Console.WriteLine(
           string.Format($"Send by Facebook: Send to all customer"
           + "\n\tDay: {0}"
           + "\n\tContent: {1}"
           + "\n\tDescription: {2}",
           notificationData.GetDay(),
           notificationData.GetContent(),
           notificationData.GetDescription()
           ));
        }
    }
}
