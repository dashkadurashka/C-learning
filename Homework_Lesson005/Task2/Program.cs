//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = Prompt("Введите желаемый размер массива: ");
int[] arrayResult = new int [size];
int elementSum = 0;

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
        array[i] = new Random().Next(-10, 11); 
    }
    return array;
}

void GetElementSum(int[] array)
{
    for(int i = 1; i < array.Length; i += 2)
    {
        elementSum += array[i];
    }
}

void PrintResult(int[] array, int elementSum)
{
    Console.WriteLine($"Массив: {String.Join(",", array)}");
    Console.WriteLine($"Cумма элементво массива на нечетных позициях: {elementSum}");
}

arrayResult = GetArray();
GetElementSum(arrayResult);
PrintResult(arrayResult, elementSum);