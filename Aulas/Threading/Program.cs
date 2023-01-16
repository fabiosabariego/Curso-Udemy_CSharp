using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World 1");
            Thread.Sleep(500);
            Console.WriteLine("Hello World 2");
            Thread.Sleep(500);
            Console.WriteLine("Hello World 3");
            Thread.Sleep(500);
            Console.WriteLine("Hello World 4");

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Thread 4");
            }).Start();
            */

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} Started!");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} Ended!");
            });
            Console.WriteLine($"Thread ID: {thread.ManagedThreadId}");
            thread.Start();

            var test = taskCompletionSource.Task.Result;
            Console.WriteLine($"Task Was Done: {test}");

        }
    }
}