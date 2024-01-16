//Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе,
//младший – на последнем. 

int Merge(int[] arr)
{
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        num = num * 10 + arr[i];
    }
    return num;
}

Console.WriteLine("Введите количество элементов массива(не больше 8) ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0 && N < 9)
{
    int[] array = new int[N];
    bool proverka = true;
    Console.WriteLine("Введите элементы массива от 0 до 9 ");
    for (int i = 0; i < N; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 9)
        {
            Console.WriteLine("Число больше 9, начните снова");
            proverka = false;
            break;
        }
    }
    if (proverka == true)
        Console.WriteLine($"Целое число {Merge(array)}");
}
else
{
    Console.WriteLine("Превышение размера массива");

}