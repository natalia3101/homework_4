/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetNumber (string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter a number");
        }
    }
    return result;
}

int SumOfDigits (int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
        
    }
    return sum;
}

int number = GetNumber("Enter a number");

Console.WriteLine(SumOfDigits(number));