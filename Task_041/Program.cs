// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

Console.Clear();
Console.WriteLine();

Console.Write("Введите элементы(через пробел и запятую): ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

int CountingNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int result = CountingNumbers(arr);
Console.WriteLine($"Количество чисел больше 0: {result}");