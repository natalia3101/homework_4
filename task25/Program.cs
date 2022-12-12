/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetNumberA (string message)
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

int GetNumberB (string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter a number more than 0");
        }
    }
    return result;
}

int GetNumberToPower(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 1; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

int numberA = GetNumberA("enter a number");
int numberB = GetNumberB("enter a power");
int power = GetNumberToPower(numberA, numberB);

Console.WriteLine($"{numberA} to the power of {numberB} is {power}");
