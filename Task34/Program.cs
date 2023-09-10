// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int FindEvenNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % 2 == 0) sum++;
        }
    return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(Size, 100, 999);
PrintArray(array);
Console.WriteLine();

int count = FindEvenNumbers(array);
Console.WriteLine($"Количество четных значений в массиве составляет {count}");