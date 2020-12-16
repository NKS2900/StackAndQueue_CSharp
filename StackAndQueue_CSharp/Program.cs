using System;

namespace StackAndQueue_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListStack");
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.peek();
            stack.pop();
            stack.Display();
            stack.isEmpty();
            Console.ReadLine();
        }
    }
}
