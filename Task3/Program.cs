// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Print(int[] array, int first = 0)
{
    if (first != array.Length)
    {
        Print(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}

void Main()
{
    int[] numbers = new int[10]; // Массив для хранения случайных чисел
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(10, 100);
    }
    foreach (int n in numbers)
        System.Console.Write(n + " ");
    System.Console.WriteLine();
    Print(numbers);
}




Main();
