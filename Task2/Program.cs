//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] GetArray(int size, int minValue, int maxValue)
{
    int[]result = new int [size];
    for(int i = 0; i<size; i++)
    {
        result[i]=new Random().Next(minValue,maxValue+1);
    }
    return result;
}
int [] array = GetArray(10,-100,100);
Console.WriteLine($"[{String.Join(",",array)}]");

int sumNegative = 0;
int size = array.Length;
for (int i =0; i< size; i++)
{
    if(i%2!=0)
    {
        sumNegative+=array[i];
    }
    else
    {
        sumNegative+=0;
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах = {sumNegative}");

