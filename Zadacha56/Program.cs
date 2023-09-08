// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumStrArray(int[,] array,int rows)
{
    int sum=0;
    for(int i=0;i<array.GetLength(1);i++)
    {
        sum=sum+array[rows,i];
    }
    return sum;
}

int MinStr(int[,]array)
{
    int index=0;
    for(int i=0;i<array.GetLength(0);i++)
    {
        int min=SumStrArray(array,0);
        System.Console.WriteLine($"Сумма строки {i+1}: {SumStrArray(array,i)}");

        if(SumStrArray(array,i)<=min)
        {
            min=SumStrArray(array,i);
            index=i;
        }
    }
return index;
}



int[,] array=Matrix(5,5);
Print(array);

int i=MinStr(array);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальное значение в строке {i+1}");