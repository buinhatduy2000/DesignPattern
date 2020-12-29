using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    public class NotificationData : Subject
    {
        private DateTime _day;
        private string _content;
        private string _description;

        public DateTime GetDay()
        {
            return _day;
        }
        public void SetDay(DateTime value)
        {
            _day = value;
            notificationData();
        }

        public string GetContent()
        {
            return _content;
        }
        public void SetContent(string value)
        {
            _content = value;
            notificationData();
        }

        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string value)
        {
            _description = value;
            notificationData();
        }


        private void notificationData()
        {
             notifyObserver(null);
        }

    }
}
