// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Random random = new Random();

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] FillDoubleArray(int rows, int columns) 
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10, 100) * random.NextDouble();
        }
    }
    return array;
}


void ShowDoubleArray(double[,] array)
{
    Console.WriteLine("Массив вещественных чисел: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"'{array[i, j]:f1}' ");
        }
        Console.WriteLine();
    }
}

int rows = Prompt("Rows: ");
int columns = Prompt("Columns: ");
ShowDoubleArray(FillDoubleArray(rows, columns));