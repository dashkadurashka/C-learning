// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortArray (int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int g = 0; g < array.GetLength(1) - 1; g++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if(array[i, j+1] > array[i, j])
            {
                int temp = array[i, j+1];
                array[i, j+1] = array[i, j];
                array[i, j] = temp;
            }

        }
        }
        
    }
    return array;
}



int rows = Prompt("Rows: ");
int cols = Prompt("Columns: ");
int[,] array = FillArray(rows, cols);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));