//  Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при 
//  вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumElementOfNumber(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

for (int i = 1; i > 0; i++)
{
    Console.WriteLine("Введите целое число ");
    string count = Console.ReadLine();
    if (count == "q")
    {
        Console.WriteLine("[STOP]");
        break;
    }
    else
    {
        int number = Convert.ToInt32(count);
        if (SumElementOfNumber(number) % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }
}