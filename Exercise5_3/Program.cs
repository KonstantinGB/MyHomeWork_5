/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i =0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;

}

int Raznizha (int[] array)
{
  int max = array[0];
  int min = array[0];
  
  for(int i=0; i < array.Length; i++)
   {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
   }
   int result = max - min;
   return result;
 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write(" Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите минимальное значение массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите максимальное значение массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("разницa между максимальным и минимальным элементом массива: " + Raznizha(array));