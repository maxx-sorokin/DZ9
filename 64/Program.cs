// Задача 64: Задайте значение N. Напишите метод, который выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN || n <= 0)
{
    Console.WriteLine("Ошибка!");
    return;
}
PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n < 1)
    {
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(--n);
}