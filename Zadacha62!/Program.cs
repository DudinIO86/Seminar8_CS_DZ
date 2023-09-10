// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] ArraySpiral(int n,int m)
{
    int[,] mat=new int[n,m];

    int num=1;
    int t=0;
    int i=0;
    int j=0;
    int n1=n;
    int m1=m;

    while(num<=n1*m1)
    {
        //движение вправо
        for(j=t;j<m;j++)
        {
            mat[i,j]=num++;
        }
        //движение вниз
        j=m-1;
        for(i=t+1;i<n;i++)
        {
            mat[i,j]=num++;
        }
        //движение влево
        i=n-1;

        for(j=m-2;j>=t;j--)
        {
            mat[i,j]=num++;
        }
        //движение вверх
        j=t;
        for(i=n-2;i>t;i--)
        {
            mat[i,j]=num++;
        }
        n--;
        m--;
        t++;
        i=t;
        
    }
    return mat;
}

void Print(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
            {
                System.Console.Write($"{matrix[i, j]}    ");
            }
        
        System.Console.WriteLine();
    }
}

int[,] array=ArraySpiral(4,4);

Print(array);