using System;
using System.Threading;

namespace DelegatesEventsTest8
{
    public class WorkerTest8
    {
        public event EventHandler<ReportHoursEventArgs> ReportEvent;
        public event EventHandler ReportCompletedEvent;

        public void DoWork()
        {
            var hours = 8;

            for (int i = 0; i <= hours; i++)
            {
                OnWorkPerformed(i, ActionType.Working, new Location("KMW", "Warsaw"));
                Thread.Sleep(500);
            }

            OnWorkCompleted();
        }

        private void OnWorkPerformed(int hours, ActionType actionType, Location location){
            var eventArgs = new ReportHoursEventArgs
            {
                Hours = hours,
                ActionType = actionType,
                Location = location
            };
            ReportEvent?.Invoke(this, eventArgs);
        }

        private void OnWorkCompleted()
        {
            ReportCompletedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
