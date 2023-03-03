// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] GetArray (int m, int n)
{
    double [,] array = new double [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*(10-(-10))-10;

        }
         
    }
    return array;
}

void ShowArray (double [,] a)
{
    System.Console.WriteLine("\n\n");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(a[i,j], 2, MidpointRounding.AwayFromZero)+" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("\n\n");
}


ShowArray(GetArray(3,4));