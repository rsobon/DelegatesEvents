using System;

namespace DelegatesEventsTest7
{
    /*
     * Using built-in delegate EventHandler<T> which allows passing more data through pipeline
     */
    static class ProgramTest7
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest7();
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
