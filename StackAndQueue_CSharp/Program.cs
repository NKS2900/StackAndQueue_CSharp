using System;

namespace StackAndQueue_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListStack");
            LinkedListStack stack = new LinkedListStack();
            Console.WriteLine("LinkedList_Stack");
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.peek();
            stack.pop();
            stack.Display();
            stack.isEmpty();
            LinkedListQueue queue = new LinkedListQueue();
            Console.WriteLine("\nLinkedList_Queue");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("Dequeue Element from Queue");
            queue.Dequeue();
            queue.Display();
            Console.ReadLine();
        }
    }
}
