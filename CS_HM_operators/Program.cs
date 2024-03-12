using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine();

            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);
            Console.WriteLine();

            Matrix sum = matrix1 + matrix2;
            Console.WriteLine("Matrix 1 + Matrix 2:");
            PrintMatrix(sum);
            Console.WriteLine();

            Matrix difference = matrix1 - matrix2;
            Console.WriteLine("Matrix 1 - Matrix 2:");
            PrintMatrix(difference);
            Console.WriteLine();

            Matrix product = matrix1 * matrix2;
            Console.WriteLine("Matrix 1 * Matrix 2:");
            PrintMatrix(product);
            Console.WriteLine();

            Matrix multipliedByScalar = matrix1 * 2;
            Console.WriteLine("Matrix 1 * 2:");
            PrintMatrix(multipliedByScalar);
            Console.WriteLine();

            bool equal = matrix1 == matrix2;
            Console.WriteLine("Matrix 1 == Matrix 2: " + equal);
            Console.WriteLine();

            Console.ReadLine();
        }

        static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}