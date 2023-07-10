// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите неотрицательное число m: ");
    int n = ReadInt("Введите неотрицательное число n: ");
    System.Console.Write($"Значение функции Аккермана равно: {A(m, n)}");
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)
{
    if (m == 0) return n + 1;

    else if (n == 0) return A(m - 1, 1);

    else return A(m - 1, A(m, n - 1));
}

Main();