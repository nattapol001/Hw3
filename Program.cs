using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter '+' or '-' (or any other input to exit):");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Invalid input. Exiting program.");
                break;
            }

            Console.WriteLine("Enter the number of rows (M) in the matrix:");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns (N) in the matrix:");
            int N = int.Parse(Console.ReadLine());

            float[,] matrix1 = ReadMatrixValues(M, N);
            float[,] matrix2 = ReadMatrixValues(M, N);
            float[,] resultMatrix = (operation == "+") ? AddMatrices(matrix1, matrix2) : SubtractMatrices(matrix1, matrix2);

            Console.WriteLine("Result matrix:");
            PrintMatrix(resultMatrix);
        }
    }

    static float[,] ReadMatrixValues(int rows, int cols)
    {
        float[,] matrix = new float[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Enter value for position [{i},{j}]:");
                matrix[i, j] = float.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    static float[,] AddMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        float[,] resultMatrix = new float[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    static float[,] SubtractMatrices(float[,] matrix1, float[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        float[,] resultMatrix = new float[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(float[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}