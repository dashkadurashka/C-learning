// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int size = Prompt("Введите желаемый размер массива: ");
int[] arrayResult = new int [size];
int maxElement = arrayResult[1];
int minElement = arrayResult[1];


int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray()
{
    int [] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100); 
    }
    return array;
}

void GetMaxElement(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxElement)
            maxElement = array[i];
    }
}

void GetMinElement(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < maxElement)
            minElement = array[i];
    }
}

void PrintResult(int[] array, int maxElement, int minElement)
{
    Console.WriteLine($"Массив: {String.Join(",", array)}");
    Console.WriteLine($"Максимальный элемент {maxElement}, минимальный элемент {minElement}");
    Console.WriteLine($"Разница между элементами массива {maxElement - minElement}");
}

arrayResult = GetArray();
GetMaxElement(arrayResult);
GetMinElement(arrayResult);
PrintResult(arrayResult, maxElement, minElement);