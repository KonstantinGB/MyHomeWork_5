/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Kolichestvo(int[] array)
{
    int sum = 0;
    for(int i=1; i < array.Length; i+=2)
        sum += array[i];

    return sum;    
}

int[] summa = CreateRandomArray(7, 0, 10);
ShowArray(summa);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + Kolichestvo(summa));