using System;

namespace DelegatesEventsTest9
{
    /*
     * Using built-in delegate Action<T> which returns void
     */
    static class ProgramTest9
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest9();
//            worker.ActionDelegate += ReportHoursAction;
//            worker.DoWork();
            worker.DoWork(ReportHoursAction);

            Console.ReadKey();
        }

        private static void ReportHoursAction(int hours, ActionType actionType, Location location)
        {
            Console.WriteLine($"Hours: {hours}, Action Type: {actionType}, at Location: {location.Name}");
        }
    }
}
