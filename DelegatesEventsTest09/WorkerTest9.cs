using System;
using System.Threading;

namespace DelegatesEventsTest9
{
    /*
     * Worker passes data into the pipeline, which is Action delegate
     */
    public class WorkerTest9
    {
//        public Action<int, ActionType, Location> ActionDelegate;

        public void DoWork(Action<int, ActionType, Location> action)
        {
            var hours = 8;
            var location = new Location("KMW", "Warsaw");

            for (int i = 0; i <= hours; i++)
            {
                action(i, ActionType.Working, location);
                Thread.Sleep(500);
            }

        }

//        public void DoWork()
//        {
//            var hours = 8;
//            var location = new Location("KMW", "Warsaw");
//
//            for (int i = 0; i <= hours; i++)
//            {
//                ActionDelegate(i, ActionType.Working, location);
//                Thread.Sleep(500);
//            }
//        }
    }
}
