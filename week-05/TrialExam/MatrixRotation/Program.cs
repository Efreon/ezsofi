using System;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function named rotateMatrix 
            // that takes an n×n integer matrix (array of arrays) as parameter 
            //and returns a matrix which elements are rotated 90 degrees clockwise.
            int[,] matrixOrigin = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            RotateMatrix(matrixOrigin);
        }
        public static int[,] RotateMatrix(int[,] matrix)
        {
            int matrixLength = matrix.GetLength(0);
            int[,] matrixRotated = new int[matrixLength, matrixLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrixRotated[col, row] = matrix[matrixLength-1 - row, col];
                }
            }
            return matrixRotated;
            //for (int i = 0; i < matrixRotated.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrixRotated.GetLength(1); j++)
            //    {
            //        Console.Write(matrixRotated[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
