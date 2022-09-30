// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Запрос данных у пользователя:
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Функция Аккермана вычисляется только для положительных чисел!");
}
else
{
    int result = AkkermanFunction(m,n);
    Console.WriteLine($"Значение функции А({m}, {n}) = {result}");
}

// Метод Аккермана:
int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}
