// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int rows = Prompt("Rows: ");
int cols = Prompt("Cols: ");
int[,] array = new int[rows, cols];

           
int k = 1, t = 0, i, j = 0, n1 = rows, m1 = cols;
 
while (k <= n1 * m1)
{
    for (i = t; i < rows; i++)
        array[j, i] = k++;
        j = rows - 1;
    for (i = t + 1; i < cols; i++)
        array[i, j] = k++;
        j = cols - 1;
    for (i = rows - 2; i >= t; i--)
        array[j, i] = k++;
        j = t;
    for (i = cols - 2; i > t; i--)
        array[i, j] = k++;
        rows--;
        cols--;
        t++;
        j = t;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:d2} ");
        }
    }
}


PrintArray(array);