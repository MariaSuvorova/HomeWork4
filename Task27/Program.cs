/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

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

int number = GetNumber("Введите число");

int GetSumOfDigits(int number)
{
    int sum = 0;
    int digit = 0;
    while (number>=1)
    {
        digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }   
    return sum;
}

Console.WriteLine($"сумма цифр числа {number} равна {GetSumOfdigit(number)}");