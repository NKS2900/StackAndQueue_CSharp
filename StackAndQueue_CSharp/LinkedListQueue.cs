using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue_CSharp
{
    class LinkedListQueue
    {
        Node head = null;

        /// <summary>
        /// Enqueues methode to add the specified data in queue.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }         
        }

        /// <summary>
        /// Display queue.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty...");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data+" -> ");
                temp = temp.next;
            }
        }
    }
}
