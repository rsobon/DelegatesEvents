using System;

namespace DelegatesEventsTest10
{
    /*
     * Worker passes data into the pipeline, which is Func delegate
     */
    public class WorkerTest10
    {
        public Func<int, int, int> ActionDelegate;

        public void DoWork(int x, int y, Func<int, int, int> calcAction)
        {
            var result = calcAction(x, y);
            Console.WriteLine("Result: " + result);
        }

        public void DoWork(int x, int y)
        {
            var result = ActionDelegate(x, y);
            Console.WriteLine("Result: " + result);
        }
    }
}
