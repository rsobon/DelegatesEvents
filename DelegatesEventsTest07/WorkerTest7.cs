using System;
using System.Threading;

namespace DelegatesEventsTest7
{
    /*
     * To pass data we can use custom EventArgs and built-in delegate EventHandler<T> which accepts custom EventArgs and returns void
     */
    public class WorkerTest7
    {
        public event EventHandler<ReportHoursEventArgs> ReportEvent;
        public event EventHandler ReportCompletedEvent;

        public void DoWork()
        {
            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                var eventArgs = new ReportHoursEventArgs
                {
                    Hours = i,
                    ActionType = ActionType.Working,
                    Location = new Location("KMW", "Warsaw")
                };
                ReportEvent?.Invoke(this, eventArgs);
                Thread.Sleep(500);
            }

            ReportCompletedEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class ReportHoursEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public ActionType ActionType { get; set; }

        public Location Location { get; set; }
    }

    public enum ActionType
    {
        NotWorking,
        Working
    }

    public class Location
    {
        public Location(string name, string city)
        {
            Name = name;
            City = city;
        }

        public string Name { get; set; }

        public string City { get; set; }
    }
}
