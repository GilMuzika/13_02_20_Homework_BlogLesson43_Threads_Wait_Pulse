using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13_02_20_Homework_BlogLesson43_Threads_Wait_Pulse
{
    class AsyncPrinter
    {
        public event EventHandler<PrintEventArgs> printMessageEvent;

        private Queue<string> _queue = new Queue<string>();

        public void AddMessage(string str)
        {
            Monitor.Enter(this);                
                _queue.Enqueue(str);
            Monitor.Pulse(this);
            Monitor.Exit(this);            
        }
        public void CheckPrintMessage(object o)
        {
            string limitIsReachedMessage = string.Empty;
            bool reached = false;
            if (o is int && (int)o == 9) { limitIsReachedMessage = ", \n\nThe limit is reached"; reached = true; }

            Monitor.Enter(this);
            if (_queue.Count > 0) { Thread.Sleep(200); printMessageEvent?.Invoke(this, new PrintEventArgs { Message = _queue.Dequeue() + limitIsReachedMessage, Reached = reached }); }
            else
            {
                Monitor.Wait(this);
                printMessageEvent?.Invoke(this, new PrintEventArgs { Message = _queue.Dequeue() + limitIsReachedMessage, Reached = reached });
            }
            Monitor.Exit(this);
        }
    }
}
