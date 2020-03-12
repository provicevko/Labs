using System;

namespace Lab3
{
    public class TwoDimensionalArray
    {
        private int Rows;
        private int Cols;
        private int[,] Matrix = //diapazone [-2147483647;2147483647].   -2147483648 => false value;
        {
            {1, 546, 68, 3, 5, 78},
            {5, 4, 21, 24, 12, 79},
            {1, 56, 11, 3, 3, 95},
            {76, 36, 14, 37, 92, 23},
            {8, 5, 76, 2, 34, 11},
            {34, 23, 2, 124, 56, 856}
        };

        public int CountRows => Rows;
        public int CountCols => Cols;

        public TwoDimensionalArray()
        {
            this.Rows = this.Matrix.GetLength(0);
            this.Cols = this.Matrix.GetLength(1);
        }
        public int this[int i, int j]
        {
            private set
            {
                int shift = 5;
                Matrix[i + shift, j + shift] = value;
            }
            get
            {
                int shift = 5;
                
                if (i >= shift && j >= shift && i <= this.Rows + shift && j <=
                    this.Cols+shift)
                {
                    return Matrix[i-shift, j-shift];
                }
                else
                {
                    return Int32.MinValue;
                }
            }
        }
    }
}