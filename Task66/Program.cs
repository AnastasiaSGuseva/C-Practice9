// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum (int m, int n)
{
    if (n == m)
        return m;
    return
        n + Sum(m, n - 1);
}


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < n)
    Console.WriteLine(Sum(m, n));
if (n < m)
    Console.WriteLine(Sum(n, m));