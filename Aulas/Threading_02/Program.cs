using System.Threading;
using System.Threading.Tasks;

namespace Threading_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 1000).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} Started!");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} Ended!");
                });
            });
            Console.ReadLine();
        }
    }
}