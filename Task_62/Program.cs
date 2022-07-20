/* Задача 62. Заполните спирально массив 4 на 4.cd //


Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
 */
int n = 4;
int[,] sqareMatrix = new int[n, n];
int i = 0;
int j = 0;
int temp = 1;
int[,] GetArray()
{
while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
return sqareMatrix;
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
 int[,] result = GetArray ();
 PrintArray(result);