/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


void FillArray (int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(0, 100);
        i++;
    }
}

void PrintArray (int[] collec)
{
    int count = collec.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collec[position] + ", ");
        position++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);