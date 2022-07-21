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

double[,] CreateRandom2dDoubleArray(int rows, int colomns) 
{ 
    double[,] newArray = new double[rows, colomns]; 
    for (int i=0; i < rows; i++) 
        for (int j=0; j < colomns; j++) 
            newArray[i,j] = new Random().NextDouble(); 
    return newArray; 
} 

void Show2dDoubleArray (double[,] array) 
{ 
    for (int i=0; i < array.GetLength(0); i++) 
    { 
        for (int j=0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " "); 
        Console.WriteLine(); 
    }   
} 

void ShowElement (int x, int y, int[,] array) 
{ 
    if (x <= array.GetLength(0) && y <= array.GetLength(1))  
        { 
                int i = x - 1; 
                int j = y - 1; 
                Console.WriteLine($"The element with positions ({x}, {y}) is {array[i,j]}"); 
        } 
    else  
        Console.WriteLine("The element is not exist in this array"); 
} 

string FindArithmeticalMean (int[,] array) 
{ 
    string result = string.Empty; 
    double arithmeticalMean = 0;
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++) 
            sum += array[i, j];     
        arithmeticalMean = sum / array.GetLength(0); 
        result = " " + arithmeticalMean; 
        Console.WriteLine($"Arithmetical mean of {j+1} column:" + result); 
    }
    return result; 
} 

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

Console.Write("Input number of rows: "); 
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input number of colomns: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine();
double[,] myArray = CreateRandom2dDoubleArray(m,n); 

Show2dDoubleArray(myArray);
Console.WriteLine(); 


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
/*
Console.Write("Input number of rows: "); 
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input number of colomns: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input number of min value: "); 
int min = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input number of max value: "); 
int max = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input the position of the element in the row: "); 
int k = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input the position of the element in the colomn: "); 
int l = Convert.ToInt32(Console.ReadLine()); 

int[,] myArray = CreateRandom2dArray(m,n,min,max); 
Console.WriteLine();
Show2dArray(myArray); 

Console.WriteLine();
ShowElement(k, l, myArray); 
Console.WriteLine();
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

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

Console.WriteLine(); 
Show2dArray(myArray); 

Console.WriteLine(); 
Console.WriteLine(FindArithmeticalMean(myArray));
*/