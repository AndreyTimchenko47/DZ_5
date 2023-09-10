// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System.Reflection;

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();

for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double FindMaxNumbers(double[] arr)
{
    double max = 0;
    for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > max) max = arr [i];
        }
    return max;
}

double FindMinNumbers(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < min) min = arr [i];
        }
    return min;
}

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndDouble(Size, 0, 100);
PrintArrayDouble(array);
Console.WriteLine();

double minnumbers = FindMinNumbers(array);
double maxnumbers = FindMaxNumbers(array);
Console.WriteLine($"Разнциа минимального и максимального значения в массиве составляет {maxnumbers - minnumbers:F1}");