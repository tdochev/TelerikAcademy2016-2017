namespace Problem07.Timer
{
    using System;
    using System.Threading;

    delegate void Timer(int seconds, Action action);
    
    public class TimerDelegate
    {
        private byte ticks;
        public TimerDelegate(int seconds, Action action)
        {
            this.ticks = 5;
            while (ticks > 0)
            {
                action();
                Thread.Sleep(seconds*1000);
                --this.ticks;
            }
        }
    }
}

