// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AllNumbers(int number)
{
    if (number == 0) return 0;
    Console.Write(number + " ");
    return AllNumbers(number - 1);
    
}

int number = Prompt("M: ");

AllNumbers(number);  