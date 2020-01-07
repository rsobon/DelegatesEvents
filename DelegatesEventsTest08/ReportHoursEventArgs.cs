using System;

namespace DelegatesEventsTest8
{
    public class ReportHoursEventArgs : EventArgs
    {
        public int Hours { get; set; }

        public ActionType ActionType { get; set; }

        public Location Location { get; set; }
    }
}
