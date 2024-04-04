using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class Task1
    {
        public int Begin { get; set; }
        public int End { get; set; }
        private int[] arr;

        public Task1(int begin, int end)
        {
            Begin = begin;
            End = end;
            arr = new int[End - Begin];
            for (int i = Begin; i < End; i++)
            {
                arr[i - Begin] = i;
            }
        }

        public int MultDiapason()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
