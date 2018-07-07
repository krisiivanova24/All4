using System;
using System.Collections.Generic;
using System.Linq;

namespace mineTrain
{
    internal class Deque<T>
    {
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи
        public LinkedList<Train> LinkedListTrains = new LinkedList<Train>();

        public Deque() : this(16)
        {
        }

        public Deque(int capacity)
        {
            this.Capacity = capacity;
        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }

        public void AddFront(Train item)//**
        {
            this.LinkedListTrains.AddFirst(item);
            this.Count++;
            //добавя елемент отпред
        }

        public void AddBack(Train item)//**
        {
            this.Count++;
            this.LinkedListTrains.AddLast(item);
            //добавя елемент отзад
        }

        public Train RemoveFront()
        {
            try
            {
                Train help = this.LinkedListTrains.First();
                this.LinkedListTrains.RemoveFirst();
                return help;
            }
            catch (Exception)
            { return null; }
            //връща и премахва елемента отпред
        }

        public Train RemoveBack()
        {
            try
            {
                Train help = this.LinkedListTrains.Last();
                this.LinkedListTrains.RemoveLast();
                return help;
            }
            catch (Exception)
            { return null; }
            //връща и премахва елемента отзад
        }

        public Train GetFront()
        {
            try
            {
                return this.LinkedListTrains.First();
            }
            catch (Exception)
            { return null; }
            //връща, без да премахва, елемента отпред
        }

        public Train GetBack()
        {
            try
            {
                return this.LinkedListTrains.Last();
            }
            catch (Exception)
            { return null; }
            //връща, без да премахва, елемента отзад

        }
    }
}