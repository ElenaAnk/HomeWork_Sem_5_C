//Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[22, 42, 15, 77, 65] => 77 - 15 = 62**

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] array = GetArray(10, 10, 99);
Console.WriteLine($"[{String.Join(",", array)}]");

//int maxEl = array.Max();
//int minEl = array.Min();

int maxEl = array[0];
int minEl = array[0];

foreach (int el in array)
{
    if (el > maxEl)
    {
        maxEl = el;
    }
    if (el < minEl)
    {
        minEl = el;
    }
}

int Diff = maxEl - minEl;

Console.WriteLine($"Разница между максимальным элементом массива {maxEl} и минимальным элементом {minEl}, равна {Diff}");


