/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] arrayNumbers(int n = 10, int min = -100, int max = 101)
{
    int[] array =new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void sumUnevenPosition(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2) {count += array[i];}
    Console.WriteLine("Сумма чисел на нечетных позициях равна " + count);
}

Console.WriteLine("поочередно введите: желаемую длину массива, минимальное и максимальное значение числа в массиве");
int[] myArrayNumbers = arrayNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine(string.Join(", ", myArrayNumbers));
sumUnevenPosition(myArrayNumbers);