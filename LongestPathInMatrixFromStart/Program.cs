using System;

namespace LongestPathInMatrixFromStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Path in a matrix from start!");
            Console.WriteLine("-------------------------------------");

            int[,] inputMatrix = GetInput();
            MatrixProcessor matrixProcessor = new MatrixProcessor(inputMatrix);
            matrixProcessor.LongestPathInMatrixFromStart();

            Console.ReadLine();
        }

        private static int[,] GetInput() {
            int[,] inputMatix = null;
            Console.WriteLine("Enter the number of rows of the matrix");
            try
            {
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of colums of the matrix");
                int columns = int.Parse(Console.ReadLine());
                inputMatix = new int[rows, columns];
                for (int i = 0; i < rows; i++) {
                    Console.WriteLine("Enter the elements of row" + i + "separated by space");
                    String rowElements = Console.ReadLine();
                    if (!string.IsNullOrEmpty(rowElements)) {
                        string[] elements = rowElements.Split(' ');
                        for (int index = 0; index < elements.Length; index++) {
                            inputMatix[i, index] = int.Parse(elements[index]);
                        }
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("The thrown exception is"+exception.Message);
            }
            return inputMatix;
        }
    }
}
