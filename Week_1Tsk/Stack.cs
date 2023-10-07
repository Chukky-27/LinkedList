using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1Tsk
{
    public class Stack<T>
    {
        private readonly LinkedList<T> slinkedList;

        public Stack()
        {
            slinkedList = new LinkedList<T>(); 
        }
        public bool IsEmpty()
        {
            return slinkedList.Size == 0;
        }
        public void Push(T item)
        {
            slinkedList.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty())

                throw new InvalidOperationException("Stack is empty");

            T item = slinkedList.tail.Data;
            slinkedList.Remove(item);
            return item;
        }
        public T Peek()
        {
            if (IsEmpty())

                throw new InvalidOperationException("Stack is empty");

            return slinkedList.tail.Data;
        }
        public int Size()
        {
            return slinkedList.Size;
        }
    }
}
