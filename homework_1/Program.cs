// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Вы ввели не число");
    }
    return number;
}

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + SumNumbers(m + 1, n);
}

int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
System.Console.WriteLine($"Сумма чисел от {m} до {n} равна: {SumNumbers(m, n)}");