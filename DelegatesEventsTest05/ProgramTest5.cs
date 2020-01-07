using System;

namespace DelegatesEventsTest5
{
    /*
     * Using short-hand binding of handler method
     * Second event using built-in delegate EventHandler
     */
    static class Program
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest5();
            worker.ReportEvent += ReportHoursHandler;
            worker.ReportCompletedEvent += WorkCompletedHandler;
            worker.DoWork();

            Console.ReadKey();
        }

        private static void ReportHoursHandler(int hours)
        {
            Console.WriteLine("Hours: " + hours);
        }

        private static void WorkCompletedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }
    }
}
