using System;
using System.Threading;

namespace DelegatesEventsTest6
{
    /*
     * Passing more data requires more parameters in delegate definition
     * Using short-hand invoking of event
     */
    public class WorkerTest6
    {
        public delegate void ReportHoursDelegate(int hours, ActionType actionType, Location location);

        public event ReportHoursDelegate ReportEvent;
        public event EventHandler ReportCompletedEvent;

        public void DoWork()
        {
            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                ReportEvent?.Invoke(i, ActionType.Working, new Location("KMW", "Warsaw"));
                Thread.Sleep(500);
            }

            ReportCompletedEvent?.Invoke(this, EventArgs.Empty);
        }
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
