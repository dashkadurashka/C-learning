// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int negativSum = 0;
int positivSum = 0;

int[] arrayResult = new int[12];


int[] GetArray()
{
    int[] array = new int[12];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void SumArray(int[] array)
{
    foreach(int el in array)
    {
        if(el > 0)
            positivSum += el;
        else negativSum += el;  
        
    }
}

void PrintResult(int[] array, int positivSum, int negativSum) 
{
    Console.WriteLine($"Array result is {String.Join(",", array)}");
    Console.WriteLine($"Positiv sum is {positivSum}, negativ sum is {negativSum}");
}
SumArray(GetArray());

arrayResult = GetArray();
SumArray(arrayResult);
PrintResult(arrayResult, positivSum, negativSum);

