using System;

namespace DelegatesEventsTest6
{
    /*
     * Passing more data through the pipeline
     */
    static class ProgramTest6
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest6();
            worker.ReportEvent += ReportHoursHandler;
            worker.ReportCompletedEvent += WorkCompletedHandler;
            worker.DoWork();

            Console.ReadKey();
        }

        private static void ReportHoursHandler(int hours, ActionType actionType, Location location)
        {
            Console.WriteLine($"Hours: {hours}, Action Type: {actionType}, at Location: {location.Name}");
        }

        private static void WorkCompletedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }
    }
}
