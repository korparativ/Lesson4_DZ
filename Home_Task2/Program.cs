// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.

Console.WriteLine("Введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(100, 1000);
}

int SumEvenCheck(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            sum++;
    }
    return sum;
}
void PrintArray(int[] arr)
{
    foreach (int val in arr)
    {
        Console.Write($"{val} ");
    }

    Console.WriteLine();
}

PrintArray(array);
Console.WriteLine($"Четных элементов {SumEvenCheck(array)}");