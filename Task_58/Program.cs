/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение 
двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */
int n = 3, m = 4, max = 10;

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
int[,] GetArray1(int n, int m, int max)
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
int[,] multiplicationsArray(int[,] Array, int[,] Array1)
{
    int[,] resutarray = new int[n, m];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int nc = 0; nc < Array.GetLength(0); nc++)
            {
                resutarray[i, j] += Array[i, nc] * Array1[nc, j];

            }

        }
    }

    return resutarray;
}

int[,] result = GetArray(n, m, max);
PrintArray(result);
Console.WriteLine();
int[,] result1 = GetArray1(n, m, max);
PrintArray(result1);
Console.WriteLine();
PrintArray(multiplicationsArray(result, result1));
