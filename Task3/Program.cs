// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void CreateArray(int min, int max, int len = 8)
{
    int[] arr = new int[len];
    Console.Write("[ ");
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b ");
    Console.Write("]");
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


int min_number = EnterNumber("Введите минимальное число: ");
int max_number = EnterNumber("Введите максимальное число: ");

int length_arr = EnterNumber("По умолчанию длина массива равна 8, если не хотите менять введите -1: ");

if (length_arr == -1)
{
    CreateArray(min_number, max_number);
}
else if (length_arr > 0)
{
    CreateArray(min_number, max_number, length_arr);
}
else
{
    Console.WriteLine("Длина массива должна быть положительным числом");
}