// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum = sum + matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно перемножить!");
        Environment.Exit(0);
    }
    return resultMatrix;
}

int rows1 = Prompt("Rows Array 1: ");
int cols1 = Prompt("Columns Array 1: ");
int rows2 = Prompt("Rows Array 2: ");
int cols2 = Prompt("Columns Array 2: ");
int[,] matrix1 = FillArray(rows1, cols1);
int[,] matrix2 = FillArray(rows2, cols2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(ProductMatrix(matrix1, matrix2));