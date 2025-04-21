﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_SinglyLinkedList
{
    public class SinglyLinkedList<T> where T : IEquatable<T>
    {
        

        internal SinglyLinkedListNode<T>? head;               // head node of the list (or null if empty)

        internal SinglyLinkedListNode<T>? tail;               // last node of the list (or null if empty)

        /** Number of nodes in the list */
        internal int size;                      

        public SinglyLinkedList() { }              

        public int GetSize() { return size; }

        public bool IsEmpty() { return size==0; }

        // returns (but does not remove) the first element
        public T? First()
        {             
            if (IsEmpty()) return default(T);
            return head!.GetElement();
        }

        public T? Last()
        {              // returns (but does not remove) the last element
            if (IsEmpty()) return default(T);
            return tail!.GetElement();
        }

        // adds element e to the front of the list
        public void AddFirst(T e)
        {                
            head = new SinglyLinkedListNode<T>(e, head!);              
            if (IsEmpty())
                tail = head;                          
            size++;
        }

        // adds element e to the end of the list
        public void AddLast(T e)
        {
            SinglyLinkedListNode<T> newest = new SinglyLinkedListNode<T>(e, null);    
            if (IsEmpty())
                head = newest;                         
            else
                tail!.SetNext(newest);                 
            tail = newest;                          
            size++;
        }

        // removes and returns the first element
        public T? RemoveFirst()
        {                   
            if (IsEmpty()) return default(T);              
            T answer = head!.GetElement();
            head = head.GetNext();                   
            size--;
            if (size == 0)
                tail = null;                           
            return answer;
        }

        public T? RemoveLast()
        {
            if (IsEmpty()) return default(T);
            SinglyLinkedListNode<T> walk = head!;
            while (walk.GetNext() != null)
            {
                walk = walk.GetNext();
            }
            
            T answer = walk.GetElement();
            walk.SetNext(null);

            tail = walk;
            size--;
            if (IsEmpty())
            {
                tail = null;
                head = null;
            }
            return answer;
        }

        public bool Search(T e) 
        {
            // provide your code 
            SinglyLinkedListNode<T> current = head;
            if (current.GetElement().Equals(e)) return true;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
                if (current.GetElement().Equals(e)) return true;
            }
            return false;
        }

        public IEnumerable<T> Traverse()
        {
            //provide your code
            SinglyLinkedListNode<T> current = head;
         
            IEnumerable<T> items = Array.Empty<T>();
            while (current.GetNext() != null)
            {
                //items.Last(current);
                current = current.GetNext();

            }
            return items;
        }
    }
}

