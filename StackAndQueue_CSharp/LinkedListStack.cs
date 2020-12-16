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
