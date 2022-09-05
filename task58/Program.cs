﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

 Console.Write("Количество строк: ");
 int lines = Convert.ToInt32(Console.ReadLine());
 Console.Write("Количество столбцов: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 int[,] numbers = new int[lines, columns];
 int[] linSumArray = new int[lines];

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; i < numbers.GetLength(1); j++)
    sum = sum + numbers[i, j];
    linSumArray[i] = sum;
    Console.WriteLine($"Сумма строк {i}: {linSumArray[i]}");
}
Console.WriteLine();

int minSum = linSumArray[0];
int linMinSumNumber = 0;
for (int i = 0; i < linSumArray.Length; i++)
{
    if (minSum > linSumArray[i])
    {
        minSum = linSumArray[i];
        LinMinSunNumber = i;
    }
}
Console.WriteLine($"Строка номер {linMinSumNumber} с наименьшей суммой элементов {minSum}");

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(0); j++)
    array[i, j] = rand.Next(0, 100);
}
void PrintArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(0); j++)
    Console.Write(array[i, j] + "; ");
    Console.WriteLine();
}
