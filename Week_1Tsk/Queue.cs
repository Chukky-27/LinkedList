using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1Tsk
{
    public class Queue<T>
    {
        private readonly LinkedList<T> slinkedList;

        public Queue()
        {
            slinkedList = new LinkedList<T>();
        }
        public bool IsEmpty()
        {
            return slinkedList.Size == 0;
        }
        public void Enqueue(T item)
        {
            slinkedList.Add(item);
        }
        public T Dequeue()
        {
            if (IsEmpty())

                throw new InvalidOperationException("Stack is empty");

            T item = slinkedList.head.Data;
            slinkedList.Remove(item);
            return item;
        }
        public int Size()
        {
            return slinkedList.Size;
        }
    }
}
