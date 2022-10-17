/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


Printer(CreateArray(5));

int [] CreateArray (int len)
{
    int [] array = new int [len];

    for (int i=0; i<len; i++)
    {
        int rnd = new Random().Next(100, 1000);
        array[i] = rnd;
    }
    return array;
}

void Printer(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
            Console.Write($"{array[i]} ");
        }
        else{Console.Write($"{array[i]} ");}
    }
    Console.Write($" -> {count}");
}