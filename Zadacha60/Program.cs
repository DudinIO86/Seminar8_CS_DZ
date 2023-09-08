// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System.Collections.Generic;

int[,,] Matrix(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k];

    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                int temp = rand.Next(-10, 10);
                if (IsProverka(matrix, temp))
                {
                    matrix[i, j, l] = temp;
                }
                else
                {
                    l-=1;
                }
            }
        }
    }
    return matrix;
}

void Print(int[,,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        System.Console.WriteLine();
    }
}

bool IsProverka(int[,,] matr, int numb)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == numb)
                {
                    return false;
                }

            }
        }

    }
   return true;
}

int[,,] array = Matrix(2, 2, 2);
Print(array);
