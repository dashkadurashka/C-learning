// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
    Console.WriteLine();
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

void FindNumber(int[,] array, int value)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(array[i, j] == value)
            {
                Console.WriteLine($"Позиция искомого числа: {i}, {j}");
            }
           else 
           {
              count++;
           }
        }
    }
    if(count == array.GetLength(0)*array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
}


int rows = Prompt("Rows: ");
int cols = Prompt("Columns: ");
int value = Prompt("Find number: ");

PrintArray(FillArray(rows, cols));
FindNumber(FillArray(rows, cols), value);

