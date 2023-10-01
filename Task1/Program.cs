// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PositivePower(int number, int power)
{
    if (number != 0 && power == 0) return 1;
    else if (number == 0 && power == 0)
    {
        Console.WriteLine("Неопреденный результат");
        Environment.Exit(0);
    }
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }

    return result;
}

double NegativePower(int number, int power)
{
    if (number == 0)
    {
        Console.WriteLine("Деление на 0");
        Environment.Exit(0);
    }
    double result = 1;
    power = Math.Abs(power);
    for (int i = 1; i <= power; i++)
    {
        result /= number;
    }

    return result;
}

int EnterNumber(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out var number))
    {
        Console.WriteLine("Ошибка ввода");
        Environment.Exit(0);
    }
    return number;
}

int number = EnterNumber("Введите число: ");
int power = EnterNumber("Введите степень: ");
if (power < 0)
{
    Console.Write($"Число {number} в степени {power} равно {NegativePower(number, power):F5}");
}
else
{
    Console.Write($"Число {number} в степени {power} равно {PositivePower(number, power)}");
}