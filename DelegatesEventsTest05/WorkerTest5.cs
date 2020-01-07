using System;
using System.Threading;

namespace DelegatesEventsTest5
{
    /*
     * EventHandler is built-in delegate that accepts no parameters and returns void
     */
    public class WorkerTest5
    {
        public delegate void ReportHoursDelegate(int hours);

        public event ReportHoursDelegate ReportEvent;
        public event EventHandler ReportCompletedEvent;

        public void DoWork()
        {
            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                if (ReportEvent != null)
                {
                    ReportEvent(i);
                }
                Thread.Sleep(500);
            }

            if (ReportCompletedEvent != null)
            {
                ReportCompletedEvent(this, EventArgs.Empty);
            }
        }
    }
}
