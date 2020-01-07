using System;

namespace DelegatesEventsTest10
{
    /*
     * Using built-in delegate Func<T, TResult> which returns TResult
     */
    static class ProgramTest10
    {
        static void Main(string[] args)
        {
            var worker = new WorkerTest10();

            Console.WriteLine("Enter your numbers:");

            Console.WriteLine("First number: ");
            string firstNumber = Console.ReadLine();
            int.TryParse(firstNumber, out var x);

            Console.WriteLine("Second number: ");
            string secondNumber = Console.ReadLine();
            int.TryParse(secondNumber, out var y);

            Console.WriteLine("Enter your choice: \n1: Add numbers \n2: Multiply numbers");
            string input = Console.ReadLine();
            int.TryParse(input, out var calcChoice);

            switch (calcChoice)
            {
                case 1:
                    worker.DoWork(x, y, SomeCalcAdd);
//                    worker.DoWork(x, y, (inputX, inputY) => inputX + inputY);
//                    worker.ActionDelegate += SomeCalcAdd;
//                    worker.DoWork(x, y);
                    break;
                case 2:
                    worker.DoWork(x, y, SomeCalcMultiply);
//                    worker.DoWork(x, y, (inputX, inputY) => inputX * inputY);
//                    worker.ActionDelegate += SomeCalcMultiply;
//                    worker.DoWork(x, y);
                    break;
                default:
                    Console.WriteLine("Incorrect choice!");
                    break;
            }

            Console.ReadKey();
        }

        private static int SomeCalcAdd(int x, int y)
        {
            return x + y;
        }

        private static int SomeCalcMultiply(int x, int y)
        {
            return x * y;
        }
    }
}
