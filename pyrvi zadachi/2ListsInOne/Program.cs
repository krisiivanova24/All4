using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ListsInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            AddL(list1, list2);
            Sort letussort = new Sort();
            letussort.Sort1(list1);
            letussort.SortAndPrint();

        }
        static List<int> AddL(List<int> l1, List<int> l2)
        {
            for (int i = 0; i < l2.Count; i++)
            {
                l1.Add(l2[i]);
            }
            return l1;
        }

    }
    class Sort
    {
        private List<int> list;

        public List<int> List
        {
            get { return this.list; }
            set { this.list = value; }
        }
        public void Sort1(List<int> l1) {
            this.List = l1;
        }
        public void SortAndPrint()
        {
            for (int i = 0; i < this.List.Count-1; i++)
            {
                int k = i;
                for (int w = i + 1; w < this.List.Count; w++)
                {
                    if (this.List[k] < this.List[w])
                    {
                        k = w;
                    }
                    int m = this.List[k];
                    this.List[k] = this.List[w];
                    this.List[w] = m;
                }

            }
            Console.WriteLine(string.Join(" ", this.List));
        }
    }

}
