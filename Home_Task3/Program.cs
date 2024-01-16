//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним 
//и т.д.)

int[] NewArray(int count)
{
    int[] newArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        newArray[i] = new Random().Next(1, 100);
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    foreach (int val in arr)
    {
        Console.Write($"{val} ");
    }

    Console.WriteLine();
}

int[] ArrayRevers(int[] arr)
{
    int[] arrRev = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrRev[arr.Length - 1 - i] = arr[i];
    }
    return arrRev;
}

Console.WriteLine("Введите количество элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(N);

PrintArray(array);
PrintArray(ArrayRevers(array));