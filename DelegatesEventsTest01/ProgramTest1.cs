using System;

namespace DelegatesEventsTest1
{
    static class ProgramTest1
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest1();
            worker.DoWork();

            Console.ReadKey();
        }
    }
}
