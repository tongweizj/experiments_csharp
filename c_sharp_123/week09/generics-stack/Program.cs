using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestIntStack();
        }

        static void TestIntStack()
        {
            GenericStack<int> stack = new GenericStack<int>();
            Console.WriteLine("pushing 0 .. 1 in ascending value on to the stack");
            for (int i = 0; i < 15; i++)
            {
                stack.Push(i);
            }
            while (!stack.IsEmpty)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }

    }
    public class GenericStack<T>
    {
        public const int SIZE = 15;
        private int top;
        private T[] data;

        // 公共的只读属性，判断栈是否为空
        public bool IsEmpty
        {
            get
            {
                // 如果 _top 为 -1，则栈为空
                return top == -1;
            }
        }

        public GenericStack()
        {
            this.data = new T[SIZE];
            this.top = -1;
        }

        public void Push(T item)
        {
            if (top >= this.data.Length-1 )
            {
                throw new InvalidOperationException("\"Stack is full.");
            }

            this.data[++this.top] = item;
            
        }
        public T Pop() {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return this.data[this.top--];
        }   
    }
}
