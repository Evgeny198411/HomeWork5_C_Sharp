/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] arrayNumbers(int n)
{
    int[] array =new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void writeNumbersArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void evenNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) {count++;}
    }
    Console.WriteLine("В вашем массиве чётных чисел: " + count);
}

Console.WriteLine("введите желаемую длину массива трёхзначных положительных чисел");
int[] myArrayNumbers = arrayNumbers(int.Parse(Console.ReadLine()));
writeNumbersArray(myArrayNumbers);
evenNums(myArrayNumbers);
