using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStack
{
    public class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;

        public ArrayStack(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
        }


        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T result = this.elements[this.Count-1];
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
        }

        private void CopyAllElementsTo(T[] newElements)
        {
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }
        }
    }

}
