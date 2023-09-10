// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Matrix(int m, int n)
{
    int[,] matrix=new int[m,n];

    Random rand=new Random();

    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            int min=-100;
            int max=100;
            matrix[i,j]=rand.Next(0,10);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
     for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void Organize(int[,] matrix)
{
    
    for (int i=0;i<matrix.GetLength(0);i++)
    {
        
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            int max_index=MaxFunction(matrix,i,j);

            int temp=matrix[i,j];
            matrix[i,j]=matrix[i,max_index];
            matrix[i,max_index]=temp;
             
           
        }
    }

}


int MaxFunction(int[,] array,int rows,int st_col)
{
     int max=array[rows,st_col];
     int index=0;
    for(int j=st_col;j<array.GetLength(1);j++)
    {      
        
            if(array[rows,j]>=max)
            {
                max=array[rows,j];
                index=j;
            }
        
       
    }
return index;
}

int[,] array=Matrix(5,5);

Print(array);
System.Console.WriteLine();

Organize(array);

Print(array);
System.Console.WriteLine();