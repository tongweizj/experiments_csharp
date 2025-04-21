using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_SinglyLinkedList
{

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack4COMP212<T> where T : IEquatable<T>
    {
            private Node<T> top;

            public Stack4COMP212()
            {
                top = null;
            }

            // Push operation
            public void Push(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
            }

            // Pop operation
            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }
                T data = top.Data;
                top = top.Next;
                return data;
            }

            // Peek operation
            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty.");
                }
                return top.Data;
            }

            // Check if the stack is empty
            public bool IsEmpty()
            {
                return top == null;
            }

            // Get the size of the stack
            public int Contains()
            {
                int contains = 0;
                Node<T> currentNode = top;
                while (currentNode != null)
                {
                    contains++;
                    currentNode = currentNode.Next;
                }
                return contains;
            }

            // Display the stack elements
            public void Display()
            {
                Node<T> currentNode = top;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Next;
                }
            }
        }
    }

}
