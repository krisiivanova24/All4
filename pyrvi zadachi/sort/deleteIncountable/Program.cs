using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deleteIncountable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            DeleteUncount array = new DeleteUncount();
            array.Array(inputs);
            array.Sort();
            array.Print();
            array.FindAndDelete();
            array.Print();
        }
    }
    class DeleteUncount
    {
        private List<int> arr;

        public List<int> Arr
        {
            get { return this.arr; }
            set { this.arr = value; }
        }
        public void Array(List<int> arr)
        {
            this.Arr = arr;
        }
        public List<int> Sort()
        {
            for (int i = 0; i < this.Arr.Count - 1; i++)
            {
                int j = i;
                for (int k = i + 1; k < this.Arr.Count; k++)
                {
                    if (arr[k] < arr[j])
                    {
                        j = k;
                    }
                }
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
            return this.Arr;
        }
        public List<int> FindAndDelete()
        {
            int count = 1;
            List<int> insertHere = new List<int>();
            List<int> counter = new List<int>();

            //for (int i = 0; i < Arr.Count; i++)
            //{
            //    if (!insertHere.Contains(this.Arr[i]))
            //    {
            //        insertHere.Add(this.Arr[i]);
            //    }
            //}
            //for (int i = 0; i < insertHere.Count; i++)
            //{
            //    for (int f = 0; f < this.Arr.Count; f++)
            //    {
            //        if (this.Arr[f] == insertHere[i])
            //        {
            //            count++;
            //            counter.Add(count);
            //            Console.WriteLine(count+" counter");
            //        }
                    
            //    }
            //    count = 1;
            //    if (count%2==0)
            //    {
                    
            //    }
            //}
            Console.WriteLine(string.Join(" .. ", insertHere ));
            Console.WriteLine(string.Join(" ... ", counter ));
            //for (int i = 0; i < this.Arr.Count - 1; i++)
            //{
            //    if (this.Arr[i] == this.Arr[i + 1])
            //    {
            //        count++;
            //        insertHere.Add(this.Arr[i]);
            //        if (this.Arr[i] != this.Arr[i + 1])
            //        {
            //            insertHere.Add(this.Arr[i]);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(count);
            //        if (count % 2 != 0)
            //        {
            //            Console.WriteLine(string.Join(" ", insertHere ));
            //            for (int y = 0; y < insertHere.Count; y++)
            //            {
            //                this.Arr.Remove(this.Arr[y]);
            //            }
            //            insertHere.Clear();
            //            count = 1;
            //           // Console.WriteLine(2);
            //        }
            //    }

            //}

            return this.Arr;
        }
        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.Arr));
        }
    }
}
