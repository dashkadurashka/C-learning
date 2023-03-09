// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
char[] array = number.ToString().ToCharArray();
if (array.Length == 5)
{
    if(array[0] == array[4] && array[1] == array[3])
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
else
    Console.WriteLine("Incorrect number");
// Console.Write(array);
