using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            BubleSort bubble = new BubleSort();
            bubble.BubbleSort(list);
            bubble.Sort();
            bubble.Print();
        }

    }
    class BubleSort
    {
        private List<int> list;

        public List<int> List {
            get {return this.list; }
            set { this.list = value; }
        }
      
       public void BubbleSort( List<int> list){
           this.List = list;  
       }

        public List<int> Sort()
        {
                        
            for (int i = 0; i < this.List.Count - 1; i++)
            {
                for (int r = 0; r < this.List.Count - 1; r++)
                {
                    if (this.List[r] > this.List[r + 1])
                    {
                        Swap(r);
                    }
                }
            }
            return this.List;
        }
        public List<int> Swap( int r)
        {
            int smallest = this.List[r + 1];
            this.List[r + 1] = this.List[r];
            this.List[r] = smallest;
            //foreach (var item in this.List)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            return this.List;
        }
        public void Print() {
            foreach (var item in this.List)
            {
                Console.Write(item + " ");
            }
        }
    }
}
