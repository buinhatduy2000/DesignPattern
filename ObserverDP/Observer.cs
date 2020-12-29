using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDP
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(object arg);
    }
}
