// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double PromptDouble(string message) 
{
    Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}
    
double b1 = PromptDouble("Введите b1:");
double k1 = PromptDouble("Введите k1:");
double b2 = PromptDouble("Введите b2:");
double k2 = PromptDouble("Введите k2:");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y}).");