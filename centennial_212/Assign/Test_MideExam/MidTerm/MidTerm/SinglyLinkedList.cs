using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{    
        public class Node<E>
        {
            private E element { get; set; }
            private Node<E> next { get; set; }

            public Node(E data)
            {
                element = data;
                next = null;
            }
            public E getElement() { return element; }
            public Node<E> getNext() { return next; }

            public void setNext(Node<E> node) { next = node; }
        }
        public class SinglyLinkedList<E>
        {
            private Node<E> head;
            private Node<E> tail;
            private int size;

            public SinglyLinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public void addLast(E data)
            {
                Node<E> newNode = new Node<E>(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<E> current = head;
                    while (current.getNext() != null)
                    {
                        current = current.getNext();
                    }
                    current.setNext(newNode);
                }
                this.size++;
            }


            public void addFirst(E data)
            {
                Node<E> newNode = new Node<E>(data);
                newNode.setNext(head.getNext());
                head.setNext(newNode);
                this.size++;
            }
            public E first() { return head.getElement(); }
            public int getSize() { return size; }
            public bool isEmpty() { return size == 0; }
            public E last() { return tail.getElement(); }

            public void removeFirst()
            {
                head = head.getNext();
                this.size--;
            }

            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("The linked list is empty.");
                    return;
                }

                Console.WriteLine("Singly Linked List Elements:");
                Node<E> current = head;
                while (current != null)
                {
                    Console.Write(current.getElement() + "\n");
                    current = current.getNext();
                }
            }

            // new
            public Node<E> Search(E item)
            {
                Node<E> current = head;
                if (current.getElement().Equals(item)) return current;

                while (current.getNext() != null )
                {
                    current = current.getNext();
                    if(current.getElement().Equals(item)) return current;
                }
            return null;
        }
            // new
            public void Traverse()
            {

            }

        public override string ToString()
            {
                string output = "";
                if (this.size == 0)
                {
                    output = "This is a empty single linked list!";
                }
                else
                {
                    output = "This single linked list have " + this.size + " nodes.";
                }

                return output;
            }

        }
    }

