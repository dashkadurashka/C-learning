// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Random random = new Random();


int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] FillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
            Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
    return array;
}

int[,] Explorer(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 & j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
            Console.Write(array[i, j] + " ");
        }
    }
    return array;
}


int rows = Prompt("Rows: ");
int cols = Prompt("Columns: ");
Explorer(FillArray(rows, cols));
