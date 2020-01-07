using System;

namespace DelegatesEventsTest4
{
    /*
     * Using event keyword instead of publicly exposed delegate
     */
    static class ProgramTest4
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest4();
            // not allowed with events:
            // worker.ReportEvent = new WorkerTest4.ReportHoursDelegate(ReportHoursHandler);
            worker.ReportEvent += new WorkerTest4.ReportHoursDelegate(ReportHoursHandler);
            worker.ReportEvent += new WorkerTest4.ReportHoursDelegate(ReportHoursHandler2);
            worker.DoWork();

            Console.ReadKey();
        }

        private static void ReportHoursHandler(int hours)
        {
            Console.WriteLine("Hours: " + hours);
        }

        private static void ReportHoursHandler2(int hours)
        {
            Console.WriteLine("Second handler " + hours);
        }
    }
}
