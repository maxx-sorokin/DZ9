// Задача 66: Задайте значения M и N. Напишите метод, который найдёт
// сумму натуральных элементов в промежутке от M до N. Через рекурсию!


Console.Write("Введите M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

if (m <= n)
{
    Console.WriteLine(SumNumbers(m, n));
}
else
{
    Console.WriteLine(SumNumbers(n, m));
}

int SumNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    return m + SumNumbers(++m, n);
}