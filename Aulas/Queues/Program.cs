using System.Collections;
using System.Collections.Generic;

namespace Queues

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            // Printing element at the front of the queue
            Console.WriteLine($"The Value at the front of the queue is: {queue.Peek()}");

            queue.Enqueue(2);
            Console.WriteLine($"The Value at the front of the queue is: {queue.Peek()}");

            queue.Enqueue(3);
            Console.WriteLine($"The Value at the front of the queue is: {queue.Peek()}\n");

            //int queueItem = queue.Dequeue();
            //Console.WriteLine($"The Value at the front of the queue is: {queue.Peek()}");


            // Delete All number in Created Queue

            while (queue.Count > 0)
            {
                Console.WriteLine($"Deleted Number: {queue.Dequeue()}");
                Console.WriteLine($"Remain {queue.Count} more elements in Queue");
            }*/

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order ord in ReceiveOrdersFromBranch1())
            {
                // add each order to the queue
                ordersQueue.Enqueue(ord);
            }

            foreach (Order ord in ReceiveOrdersFromBranch2())
            {
                // add each order to the queue
                ordersQueue.Enqueue(ord);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }

        }

        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            return orders;
        }
    }

    class Order
    {
        // Order ID
        public int orderID { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int ID, int orderQuantity)
        {
            this.orderID = ID;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {orderID} Processed!");
        }
    }
}