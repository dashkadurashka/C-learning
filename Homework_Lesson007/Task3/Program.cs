// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindAverage(int[,] array)
{
    for (int j = 0; j<array.GetLength(1); j++)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i<array.GetLength(0); i++)
            {
                if(i == array.GetLength(0)-1)
                {
                    count++;
                    sum = sum + array[i,j];
                    double average = Math.Round(sum/count, 2);
                    Console.WriteLine($"Среднее значение {j+1} колонки: {average}");
                }
                count++;
                sum = sum + array[i,j];
            }
        }
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

int rows = Prompt("Rows: ");
int cols = Prompt("Columns: ");

PrintArray(FillArray(rows, cols));
Console.WriteLine();
FindAverage(FillArray(rows, cols));