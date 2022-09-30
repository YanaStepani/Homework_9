// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NaturalNumbers (int n)
{
    if (n == 0)
    {
        return 0;
    }
    int result = n + NaturalNumbers(n - 1);
    Console.Write(n + "\t");
    return result;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

NaturalNumbers(n);
