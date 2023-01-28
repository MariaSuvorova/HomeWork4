/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}
int length = GetNumber("Введите длину массива");

int[] CreateArray(int length)
{
    int[] arrayOfDigit = new int[length];
    for (int i = 0; i<=length-1; i++)
    {
        arrayOfDigit[i] = GetNumber($"Введите {i} элемент массива");
    }
    return arrayOfDigit;
}
int[] digits = CreateArray(length);

void PrintArray(int[] arrayofdigits)
{
    Console.Write("ввели массив: ["); 
    for (int i=0; i<arrayofdigits.Length-1; i++)
        Console.Write($"{arrayofdigits[i]}, "); 
    Console.Write($"{arrayofdigits[arrayofdigits.Length-1]}]"); 
}

PrintArray(digits);

