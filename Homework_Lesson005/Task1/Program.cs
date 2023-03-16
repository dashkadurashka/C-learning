// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = Prompt("Введите желаемый размер массива: ");
int[] arrayResult = new int [size];
int count = 0;


int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray()
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void GetCount(int[] array)
{
    foreach(int el in array)
    {
        if(el % 2 == 0)
        {
            count += 1;
        }
    }
}

void PrintResult(int[] array, int count)
{
    Console.WriteLine($"Массив: {String.Join(",", array)}");
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

arrayResult = GetArray();
GetCount(arrayResult);
PrintResult(arrayResult, count);
