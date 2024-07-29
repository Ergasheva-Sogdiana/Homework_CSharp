// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите число М: ");
    int N = ReadInt("Введите число N: ");
    PrintNumber(M, N);
}

void PrintNumber(int M, int N)
{
    if (N < M) return;
    PrintNumber(M, N - 1);
    System.Console.WriteLine(N + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();

