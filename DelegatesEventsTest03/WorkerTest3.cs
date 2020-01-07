using System.Threading;

namespace DelegatesEventsTest3
{
    /*
     * All subscribers from the invocation list are going to be notified
     */
    public class WorkerTest3
    {
        public delegate void ReportHoursDelegate(int hours);

        public ReportHoursDelegate ReportDelegate;

        public void DoWork()
        {
            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                ReportDelegate(i);
                Thread.Sleep(500);
            }
        }
    }
}
