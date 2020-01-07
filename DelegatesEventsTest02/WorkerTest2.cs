using System;
using System.Threading;

namespace DelegatesEventsTest2
{
    /*
     * Worker doesn't know who is subscribed to Delegate. Invoking delegate will only pass data to the pipeline
     * Public delegate is exposed as public field (global variable)
     */
    public class WorkerTest2
    {
        public delegate void ReportHoursDelegate(int hours);

        public ReportHoursDelegate ReportDelegate;

        public void DoWork()
        {
            Console.WriteLine("Delegate method: " + ReportDelegate.Method);
            Console.WriteLine("Delegate target: " + ReportDelegate.Target);

            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                ReportDelegate(i);
                Thread.Sleep(500);
            }
        }
    }
}
