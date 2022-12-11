/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

void task1()
{
    natural(new_value(), 1);

    int natural(int N, int b)
    {
        if (N == b)
        {
            Console.Write($"{N}");
            return 0;
        }
        Console.Write($"{N}, ");
        return natural(N - 1, b);
    }
}

void task2()
{
    Console.Write(sum(new_value(), new_value()));

    int sum(int N, int b)
    {
        if (N == b)
        {
            return N;
        }
        return N + sum(N + 1, b);
    }
}

void task3()
{
    Console.Write(summa(new_value(), new_value()));

    int summa(int m, int n)
    {
        if (m == 0)
        {
            return n+1;
        }
        else if (n == 0)
        {
            return summa(m - 1, 1);
        }
        else
        {
            return summa(m - 1, summa(m, n - 1));
        }
    }
}

while (true)
{
    Console.WriteLine();
    Console.Write("Введите номер задачи: ");
    int num = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (num)
    {
        case 1:
            {
                task1();
                break;
            }
        case 2:
            {
                task2();
                break;
            }
        case 3:
            {
                task3();
                break;
            }
    }
}

int new_value()
{
    Console.WriteLine("Введите число");
    return int.Parse(Console.ReadLine());
}

void write_2_arr(int[,] arr) // вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}