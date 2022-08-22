// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

int AF(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AF(m - 1, 1);
    if (m > 0 && n > 0)
        return AF(m - 1, AF(m, n - 1));
    return 0;
}

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AF(m, n));