int[] CreateArray(int size) 
{ 
    int[] newArray = new int[size]; 
    Console.WriteLine("Creating array here: "); 

    for (int i = 0; i < size; i++) 
    { 
        Console.Write($"Input {i + 1} element: "); 
        newArray[i] = Convert.ToInt32(Console.ReadLine()); 
    } 
    Console.WriteLine(); 
    return newArray; 
} 

void ShowArray(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
    Console.WriteLine(); 
} 

int CountOfPositive (int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] > 0) count++; 
    return count; 
} 

double IntersectionPoint (double a1, double m1, double a2, double m2) 

{ 
    double x = (a2 - a1)/(m1-m2); 
    double y = m1*x + a1; 
    Console.WriteLine($"Intersection coordinates: x = {x}, y = {y}"); 
    return x; 
    return y; 
} 

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Input size of array: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArray(m); 
ShowArray(array); 
Console.WriteLine("Positive elements amount is " + CountOfPositive(array)); 

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input b1: "); 
double b1 = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Input k1: "); 
double k1 = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Input b2: "); 
double b2 = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Input k2: "); 
double k2 = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine(IntersectionPoint(b1, k1, b2, k2)); 
*/