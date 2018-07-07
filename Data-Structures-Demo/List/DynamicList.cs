using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.Element = element;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            if (count == 0)
            {
                Node current = new Node(item);
                this.head = current;
                this.tail = current;
            }
            else
            {
                Node current = new Node(item, tail);
                tail = current;
            }
            count++;
        }
        public object Remove(int index)
        {
            var currentIndex = 0;
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        this.head = current.Next;
                    }
                    if (current.Next == null)
                    {
                        this.tail = previous;
                    }
                    count--;
                    return current.Element;
                }
                current = current.Next;
                previous = current;
                currentIndex++;
            }
            return null;
        }
        
        public int Remove(object item)
        {
            var index = this.IndexOf(item);
            var currentObject = this.Remove(index);
            if (currentObject == null)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        public int IndexOf(object item)
        {
            var index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(object item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }
        public object this[int index]
        {
            get
            {
                var currentIndex = 0;
                Node current = head;
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        return current.Element;
                    }
                    current = current.Next;
                    currentIndex++;
                }
                return -1;
            }

            set
            {
                var currentIndex = 0;
                Node current = head;
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        current.Element = value;
                        break;
                    }
                    current = current.Next;
                    currentIndex++;
                }

            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
    }

}
