using System;
using System.Text;

namespace StackAndQueue_CSharp
{
    class LinkedListStack
    {
        public Node top;

        /// <summary>
        /// Contructor to initialize top value.
        /// </summary>
        public LinkedListStack()
        {
            top = null;
        }

        /// <summary>
        /// push the element in stack.
        /// </summary>
        /// <param name="value"></param>
        public void push(int value)
        {
            Node node = new Node(value);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            
        }

        /// <summary>
        /// peek the top most element from stack.
        /// </summary>
        internal void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty...");
            }
            Console.WriteLine("\nTop Most Element in Stack : " + top.data);
        }

        /// <summary>
        /// Pop remove the top Element from stack.
        /// </summary>
        internal void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty... ");
            }
            Console.WriteLine("Deleted Element : " + top.data);
            top = top.next;
        }

        /// <summary>
        /// Cheking stack isEmpty or not 
        /// </summary>
        internal void isEmpty()
        {
            while (top != null)
            {
                peek();
                pop();
            }
            Console.WriteLine("Stack is Empty...");
        }
        /// <summary>
        /// Display Stack.
        /// </summary>
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data+" -> " );
                temp = temp.next;
            }
        }
    }
}
