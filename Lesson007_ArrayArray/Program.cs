

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 11);
        Console.Write(array[i, j] + " ");
    }
}
