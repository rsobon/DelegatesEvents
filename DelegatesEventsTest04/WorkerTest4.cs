using System.Threading;

namespace DelegatesEventsTest4
{
    /*
     * Public event is exposed like a property - only add/remove methods are accessible
     */
    public class WorkerTest4
    {
        public delegate void ReportHoursDelegate(int hours);

        public event ReportHoursDelegate ReportEvent;

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
        }
    }
}
