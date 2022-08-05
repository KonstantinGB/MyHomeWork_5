/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;

}

int Kolichestvo(int[] array)
{
    int sum = 0;
    for(int i=0; i < array.Length; i++)
        if(array[i] % 2 == 0) sum += 1;

    return sum;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] kolishestvo = CreateRandomArray(6, 100, 999);
ShowArray(kolishestvo);
Console.WriteLine(" Количество количество чётных чисел в массиве: " + Kolichestvo(kolishestvo));