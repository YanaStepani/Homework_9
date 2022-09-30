// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int AdditionNaturalNumbers (int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    int result = n + AdditionNaturalNumbers(m, n - 1);
    Console.Write(n + "\t");
    return result;
}

Console.WriteLine("Введите число начала ряда: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число окончания ряда: ");
int n = int.Parse(Console.ReadLine());

int sum = AdditionNaturalNumbers(m, n);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {m} до {n} = {sum}");
