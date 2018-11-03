using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPathInMatrixFromStart
{
    class MatrixProcessor
    {
        private int[,] matrix { get; set; }

        public MatrixProcessor(int[,] matrix) {
            this.matrix = matrix;
        }

        public void LongestPathInMatrixFromStart() {

            int longestPathFromStart = 0;

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] dpTable = new int[rows, columns];

            longestPathFromStart = LongestPathFromStart(0,0, dpTable);

            Console.WriteLine("The Longest Path From Start of the matrix is "+longestPathFromStart);
        }

        private int LongestPathFromStart(int i, int j, int[,] dpTable) {
                      

            if (dpTable[i, j] == 0)
            {
                int maxSum = 0;

                if (i == matrix.GetLength(1)-1 && j == matrix.GetLength(0)-1)
                    return dpTable[i,j] = 1;

                if (i == matrix.GetLength(1)-1 && j == matrix.GetLength(0)-1)
                    maxSum = 1;

                if (j + 1 < matrix.GetLength(1) && matrix[i, j] < matrix[i, j + 1])
                {
                    maxSum = 1 + LongestPathFromStart(i, j + 1, dpTable);
                }

                if (i + 1 < matrix.GetLength(0) && matrix[i, j] < matrix[i + 1, j])
                {
                    maxSum = Math.Max(maxSum, 1 + LongestPathFromStart(i + 1, j, dpTable));
                }

                dpTable[i, j] = maxSum;
            }
            return dpTable[i,j];
        }
    }
}
