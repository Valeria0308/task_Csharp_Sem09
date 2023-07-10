// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    int M = ReadInt("Введите значение M");
    int N = ReadInt("Введите значение N");
    System.Console.WriteLine($"Сумма натуральных элементов от M до N равна: {SumNumbers(M, N)}");
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int N, int M)
{
    if (N == M) return N;
    return SumNumbers(N + 1, M) + N;
}

Main();