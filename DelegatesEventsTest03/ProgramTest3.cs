using System;

namespace DelegatesEventsTest3
{
    /*
     * Type of delegate is inferred by compiler
     * Multiple subscribers
     */
    static class ProgramTest3
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest3();
            worker.ReportDelegate += ReportHoursHandler;
            worker.ReportDelegate += ReportHoursHandler2;
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
