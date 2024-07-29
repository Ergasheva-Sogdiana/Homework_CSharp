//  Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


void Main()
{
    int m = ReadInt("Введите число М: ");
    int n = ReadInt("Введите число N: ");
    System.Console.WriteLine(Accerman(m, n));
}

int Accerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0)
        return Accerman(m - 1, 1);

    else
        return Accerman(m - 1, Accerman(m, n - 1));
}




int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();




