// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int[] ArraySumOfRows(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {   int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum += array[i, j]; 
        }
        arraySum[i] = sum;
    }
    return arraySum;
}

void PrintArrayOfSum(int[] arraySum)
{
    Console.Write("Массив сумм: ");
    for (int i = 0; i < arraySum.Length; i++)
    {
        Console.Write($"{arraySum[i]} ");
    }
}

int FindIndexMinSum(int[] arraySum)
{
    int indexMinSum = 0;
    int min = arraySum[0];
    for (int i = 0; i < arraySum.Length; i++)
    {
        if(arraySum[i] < min)
        {
            min = arraySum[i];
            indexMinSum = i;
        }
    }
    return indexMinSum;
}

void PrintIndexMinSum(int indexMinSum)
{
    Console.WriteLine();
    Console.WriteLine($"Номер строки с минимальной суммой элементов: {indexMinSum + 1}");
}


int rows = Prompt("Rows: ");
int cols = Prompt("Columns: ");

int[,] array = FillArray(rows, cols);
PrintArray(array);
Console.WriteLine();
ArraySumOfRows(array);
PrintArrayOfSum(ArraySumOfRows(array));

PrintIndexMinSum(FindIndexMinSum(ArraySumOfRows(array)));

