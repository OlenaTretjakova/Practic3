using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class Matrix
    {
        private int _row { get; set; }
        private int _col { get; set; }
        private int[,] _arr;

        public Matrix(int row, int col)
        {
            _row = row;
            _col = col;
            _arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    _arr[i, j] = 0;
                }
            }
        }

        public Matrix(int[,] arr)
        {
            _row = arr.GetLength(0);
            _col = arr.GetLength(1);
            _arr = arr;
        }

        public int GetMaxValue()
        {
            int maxValue = _arr[0, 0];
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    maxValue = (_arr[i, j] > maxValue) ? _arr[i, j] : maxValue;
                }
            }
            return maxValue;
        }

        public void ShowMatrix()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.Write(_arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShowMaxValue()
        {
            Console.WriteLine("Max value: " + GetMaxValue());
        }
    }

}
