//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(10, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int count = 0;

foreach (int el in array)
{
    count += el % 2 == 0 ? 1 : 0;
}
Console.WriteLine($"Количество чётных числе в данном массиве = {count}");

