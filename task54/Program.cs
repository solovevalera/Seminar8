// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


 Console.Write("Количество строк: ");
 int lines = Convert.ToInt32(Console.ReadLine());
 Console.Write("Количество столбцов: ");
 int columns = Convert.ToInt32(Console.ReadLine());
 int[,] numbers = new int[lines, columns];

 FillArray(numbers);
 Console.WriteLine("Original:");
 PrintArray(numbers);
 SortArray(numbers);
 Console.WriteLine("Sorted:");
 PrintArray(numbers);

 void Sortarray(int[,] array)
 {
    int buffer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (array[i, n] > array[i, n - 1])
            {
                buffer = array[i, n - 1];
                array[i, n - 1] = array[i, n];
                array[i, n] = buffer;
            }
        }
    }
    }
 }

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(0); j++)
array[i, j] = rand.Next(0, 100);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(0); j++)
Console.Write(array[i, j] + "; ");
Console.WriteLine();
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(0); j++)
Console.Write(array[i, j] + "; ");
Console.WriteLine();
}
