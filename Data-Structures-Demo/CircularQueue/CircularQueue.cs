using System;
using System.Collections.Generic;
using System.Text;

namespace CircularQueue
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        public int Count { get; private set; }
        private T[] elements;
        int startIndex = 0;
        int endIndex = 0;

        public CircularQueue(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T result = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return result;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            CopyAllElementsTo(array);
            return array;
        }

        private void Grow()
        {
            var newElements = new T[this.elements.Length * 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyAllElementsTo(T[] newElements)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                newElements[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }
    }

}
