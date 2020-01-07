using System;

namespace DelegatesEventsTest8
{
    /*
     * Split classes to separate files
     */
    static class ProgramTest8
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest8();
            worker.ReportEvent += ReportHoursHandler;
            worker.ReportCompletedEvent += WorkCompletedHandler;
            worker.DoWork();

            Console.ReadKey();
        }

        private static void ReportHoursHandler(object sender, ReportHoursEventArgs e)
        {
            Console.WriteLine($"Hours: {e.Hours}, Action Type: {e.ActionType}, at Location: {e.Location.Name}");
        }

        private static void WorkCompletedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }
    }
}
