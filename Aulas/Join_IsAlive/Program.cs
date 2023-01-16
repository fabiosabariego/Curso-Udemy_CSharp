using System.Threading;
using System.Xml;

namespace Join_IsAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function Done!");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn`t done within 1 second");
            }

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 is still doing stuff");
            }
            else
            {
                Console.WriteLine("Thread1 Completed!!!");
            }

            thread2.Join();
            Console.WriteLine("Thread2Function Done!");

            Console.WriteLine("Main Thread Ended");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function Started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function Started");
        }
    }
}