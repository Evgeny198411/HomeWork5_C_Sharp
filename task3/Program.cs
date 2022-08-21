/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double[] arrayDouble(int n = 10, int min = -100, int max = 100)
{
    double[] array = new double[n];
    min *= 10000;
    max = (max) * 10000;
    for (int i = 0; i < n; i++)
    {
        int num = new Random().Next(min, max + 1);
        array[i] = num / 10000.0;
    }
    return array;
}

void maxMinDouble(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) {max = array[i];}
        else if(array[i] < min) {min = array[i];}
    }
    Console.WriteLine($"Максимальный элемент в массиве: {max}, \nминимальный элемент в массиве: {min}, \nразница между максимальным и минимальным элемнтом массива: {max - min}");
}

Console.WriteLine("Для получения массива вещественных чисел поочередно введите: \nжелаемую длину массива, минимальное и максимальное значение элемента в массиве (целые числа)");
double[] myArrayNumbers = arrayDouble(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

Console.WriteLine(string.Join(" ", myArrayNumbers));

maxMinDouble(myArrayNumbers);
