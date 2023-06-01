using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2] { { 2, 3 }, { 4, 5 } };

            double determinant = CalculateDeterminant(matrix);
            Console.WriteLine($"The determinant of the matrix is: {determinant}");

            Console.ReadLine();
        }

        static double CalculateDeterminant(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows != cols)
            {
                throw new ArgumentException("Matrix is not square.");
            }

            if (rows == 1)
            {
                return matrix[0, 0];
            }

            double determinant = 0;
            double sign = 1;
            for (int i = 0; i < rows; i++)
            {
                int[,] subMatrix = CreateSubMatrix(matrix, i);
                determinant += sign * matrix[0, i] * CalculateDeterminant(subMatrix);
                sign *= -1;
            }

            return determinant;
        }

        static int[,] CreateSubMatrix(int[,] matrix, int excludeCol)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] subMatrix = new int[rows - 1, cols - 1];
            int colIndex = 0;
            for (int col = 0; col < cols; col++)
            {
                if (col != excludeCol)
                {
                    for (int row = 1; row < rows; row++)
                    {
                        subMatrix[row - 1, colIndex] = matrix[row, col];
                    }
                    colIndex++;
                }
            }

            return subMatrix;
        }
    }

}
}
