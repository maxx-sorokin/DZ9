// Задача 64: Задайте значение N. Напишите метод, который выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
PrintNumbers(n);

void PrintNumbers(int n, int i = 1)
{
    if (i > n)
    {
        return;
    }
    Console.Write($"{i} ");
    PrintNumbers(n, i + 1);
}