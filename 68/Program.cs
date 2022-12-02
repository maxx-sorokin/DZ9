// Задача 68: Напишите метод вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine(Ackermann(m, n));

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return ++n;
    }
    if (m > 0 & n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 & n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(m, n);
}