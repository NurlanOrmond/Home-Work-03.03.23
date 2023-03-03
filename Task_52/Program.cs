// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] GetArray (int m, int n)
{
    double [,] array = new double [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }         
    }
    return array;
}

void ShowArray (double [,] a) 
{
    System.Console.WriteLine("\nYour matrix:\n");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write(a[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    
}

double [] GetMeanArray (double [,] arr)
{
    double [] mean = new double [arr.GetLength(1)];
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {  
            double sum =0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = sum+arr[i,j];
                mean[j] = sum/arr.GetLength(1);
            }
        }
    return mean;
}

void ShowMeanArray (double [] d)
{
    System.Console.WriteLine("\nArithmetic mean of columns:");
    foreach (var item in d)
    {
        System.Console.Write(Math.Round(item,2)+" ");
    }
    System.Console.WriteLine("\n\n");
}

System.Console.Write("\n\nEnter the number of rows in the matrix: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("\nEnter the number of columns in the matrix: ");
int n = int.Parse(Console.ReadLine());
double [,] d = GetArray(m,n);
ShowArray (d);
ShowMeanArray(GetMeanArray(d));









