/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по
 убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8 */
int n = 3, m = 4, max = 100;

int[,] GetArray(int n, int m, int max)
{
    int[,] Array = new int[n, m];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(1, max);
        }
    }
    return Array;
}
void PrintArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}" + "\t");
        }
        Console.WriteLine();
    }
}
int[,] PoriadokArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int n = 0; n < 4; n++)
            {
                if (Array[i, j] < Array[i, n])
                {
                    int change = 0;
                    change = Array[i, n];
                    int change1 = Array[i, j];
                    Array[i, j] = change;
                    Array[i, n]=change1;
                }

            }
        }
    }
    return Array;
}
int[,] result = GetArray(n, m, max);
PrintArray(result);
Console.WriteLine();
int[,] result1 = PoriadokArray(result);
PrintArray(result1);

