using System;
using System.Threading;

namespace DelegatesEventsTest1
{
    /*
     * Delegates are action pointers (a pipeline)
     */
    public class WorkerTest1
    {
        private delegate void ReportHoursDelegate(int hours);

        public void DoWork()
        {
            var reportDelegate = new ReportHoursDelegate(ReportHoursHandler);

            Console.WriteLine("Delegate method: " + reportDelegate.Method.ToString());
            Console.WriteLine("Delegate target: " + reportDelegate.Target.ToString());

            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                reportDelegate(i);

                Thread.Sleep(500);
            }
        }

        private void ReportHoursHandler(int hours)
        {
            Console.WriteLine("Hours: " + hours);
        }
    }
}
