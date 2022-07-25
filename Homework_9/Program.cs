int CountDigits (int num) 
{ 
    if (num/10 > 0) 
        return CountDigits (num/10) + 1; 
    else 
        return 1; 
} 

int SumOfNums (int m, int n) 
{ 
    if (n >= m) 
        return SumOfNums(m,n-1) + n; 
    else return 0; 
} 

//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом. 

Console.Write("Input a number: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine (CountDigits (n)); 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
/*
Console.Write("Input the first number: "); 
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input the second number: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine();
Console.WriteLine($"Sum of elements from {m} to {n}: {SumOfNums (m, n)}");
Console.WriteLine();
*/