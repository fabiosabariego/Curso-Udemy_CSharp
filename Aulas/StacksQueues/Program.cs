using System.Collections.Generic;

namespace StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // USING STACKS LIFO   ->   Last In First Out
            Stack<int> stack = new Stack<int>();

            if (stack.Count > 0)
            {
                stack.Pop();
            }

            //stack.Push(1);      // Adiciona um Objeto no Topo (Pensando em uma pilha de pedras)
            //stack.Push(2);

            //Console.WriteLine($"Top Value in the Stack is: {stack.Peek()}\n");        // Mostra o Valor que esta no topo sem remover ele

            stack.Push(1);
            Console.WriteLine($"Top Value in the Stack is: {stack.Peek()}");

            stack.Push(2);
            Console.WriteLine($"Top Value in the Stack is: {stack.Peek()}");

            stack.Push(3);
            Console.WriteLine($"Top Value in the Stack is: {stack.Peek()}\n");


            /*int myPopStack = stack.Pop();           // Remove o Valor que esta no topo (ou ultimo valor recebido)
            Console.WriteLine($"Popped item: {myPopStack}");
            Console.WriteLine($"Top Value in the Stack is: {stack.Peek()}");*/


            // EXERCICO -> Execute um laco para remover todos os valores colocados
            while(stack.Count > 0)
            {
                Console.WriteLine($"O valor removido do Stack foi: {stack.Pop()}");
                Console.WriteLine($"O valor Atual e: {stack.Count}");
            }
            Console.WriteLine("Todos Valores foram Removidos!");
            // ----------------------------------------------------------------------

            int[] numberArray = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The Number in Array are: ");

            foreach (int number in numberArray)
            {
                Console.Write($"{number} ");
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Reverse Array: ");
            while(myStack.Count > 0)
            {
                Console.Write($"{myStack.Pop()} ");
            }

        }


    }
}