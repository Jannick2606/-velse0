using System;
using System.Threading;

namespace Øvelse0
{
    class ThreadPoolDemo
    {
        public void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }
        public void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }
        static void Main()
        {
            ThreadPoolDemo tpd = new ThreadPoolDemo();

            //adds 2 methods to a queue so the threads in the threadpool can execute them when they're available
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(tpd.Task1);
                ThreadPool.QueueUserWorkItem(tpd.Task2);
            }
            Console.Read();
        }
    }
}
