int[] RandomArray(int size) 
{ 
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(100, 1000); 
    return newArray; 
} 

void ShowArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
    Console.WriteLine(); 
} 

int CountOFEven (int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] % 2 == 0) count++; 
    return count; 
} 

int[] CreateRandomArray(int size, int minValue, int maxValue) 
{ 
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue + 1); 
    return newArray; 
}

int Sum (int[] array) 
{ 
    int summa = 0; 
    for (int i = 0; i < array.Length; i++) 
        if (i % 2 == 1) summa+=array[i]; 
    return summa; 
} 

double[] Array(int size) 
{ 
    double[] newArray = new double[size]; 
    for (int i = 0; i < size; i++) 
        newArray[i] = new Random().NextDouble(); 
    return newArray; 
} 

void PrintArray(double[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
    Console.WriteLine(); 
} 

double Difference (double[] array) 
{ 
    double maxEl = array[0]; 
    double minEl = array[0]; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] > maxEl) maxEl = array[i]; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] < minEl) minEl = array[i]; 
    double result = maxEl - minEl; 
    return result; 
} 

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = RandomArray(size); 
ShowArray(array); 
Console.WriteLine("Count of even elements in this array is " + CountOFEven(array)); 

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
/*
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input min possible value of elements: "); 
int min = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input max possible value of elements: "); 
int max = Convert.ToInt32(Console.ReadLine()); 

int[] array = CreateRandomArray(size, min, max); 
ShowArray(array); 
Console.WriteLine("The sum of elements in odd positions is " + Sum(array)); 
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
/*
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
double[] massive = Array(size); 
PrintArray(massive); 
Console.WriteLine("The difference between min and max value of elements is " + Difference(massive)); 
*/