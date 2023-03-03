// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int [,] GetArray (int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }         
    }
    return array;
}

void ShowArray (int [,] a)
{
    System.Console.WriteLine("\n\n");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write(a[i,j]+" ");
        }
        System.Console.WriteLine();
    }
    
}

void ValueOfIndex (int [,] arr)
{
    System.Console.Write("\nEnter row index: ");
    int row = int.Parse(Console.ReadLine());
    System.Console.Write("Enter column index: ");
    int col = int.Parse(Console.ReadLine());

    if (row < arr.GetLength(0) && col < arr.GetLength(1))
    {
        System.Console.WriteLine($"\nThe value positioned at row ({row}) column ({col}) is: {arr[row,col]} \n\n" );
    } 
    else System.Console.WriteLine($"\nThe value positioned at row {row} column {col} is not exist! \n\n" );


}

int [,] a = GetArray (5,5);
ShowArray (a);
ValueOfIndex (a);
