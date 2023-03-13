// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Random random = new Random();
int[] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 101);

}

string arrays = String.Join(" ", array);
Console.WriteLine(arrays);
