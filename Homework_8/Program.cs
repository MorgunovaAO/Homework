int[,] CreateRandom2dArray (int rows, int colomns, int minValue, int maxValue)
{ 
    int[,] newArray = new int[rows, colomns]; 
    for (int i=0; i < rows; i++) 
        for (int j=0; j < colomns; j++) 
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
    return newArray; 
} 

void Show2dArray (int[,] array) 
{ 
    for (int i=0; i < array.GetLength(0); i++) 
    { 
        for (int j=0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " "); 
        Console.WriteLine();
    }     
} 

int[,] Sort2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int k = 0; k < array.GetLength(1)-1; k++)
            for (int j = 0; j < array.GetLength(1)-1; j++)                 
                    if (array[i,j] <= array[i, j+1])
                    {
                        int temp = array[i,j];
                        array[i,j] = array[i, j+1];
                        array[i, j+1] = temp;
                    }   
    return array;
}

int FindMinRow (int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];  

        if (i==0) minSum = sum;
        if (sum < minSum) 
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

int [,] FillArrayAsSpiral(int n)
{
    int[,] array = new int[4, 4];
    int i = 0;
    int j = 0;
    int temp = n;
    while (temp <= array.GetLength(0) * array.GetLength(1) + n - 1)
    {
        array[i, j] = temp;
        temp++; 
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else 
            if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
            else 
                if (i >= j && i + j > array.GetLength(1) - 1)
                    j--;
                else
                    i--;
    }
    return array;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();

Console.WriteLine("New array:");
Show2dArray(Sort2dArray(myArray));
Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();

Console.WriteLine($"Row number with the smallest sum of elements: {FindMinRow (myArray)+1} row");
*/

// Задача 62. Заполните спирально массив 4 на 4.
/*
Console.Write("Input the first element: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] myArray = FillArrayAsSpiral(m);
Show2dArray (myArray);
*/