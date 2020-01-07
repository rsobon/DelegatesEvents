using System;

namespace DelegatesEventsTest2
{
    /*
     * Subscribe to delegate outside of Worker class
     */
    static class ProgramTest2
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest2();
            worker.ReportDelegate = new WorkerTest2.ReportHoursDelegate(ReportHoursHandler);
            worker.DoWork();

            Console.ReadKey();
        }

        private static void ReportHoursHandler(int hours)
        {
            Console.WriteLine("Hours: " + hours);
        }
    }
}
