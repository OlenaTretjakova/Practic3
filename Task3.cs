using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    using System;

    internal class Task3
    {
        private int[] arr;

        public int Size
        {
            get { return arr.Length; }
            set { arr = new int[value]; }
        }

        public Task3(int size, int[]Arr)
        {
            arr = new int[size];
        }

        public static void SortArr(int[] array)
        {
            Array.Sort(array);
        }

        public static void PrintArr(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
