/* Задача 1. Показать 2-ю цифру трехзн. числа:

int CutNumber(int num)
{
    int des = (num % 100) / 10;
    return des;
}

Console.Write("Input a number between 100 and 999: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber (number));
*/ 

/* Задача 2. Показать третью слева цифру числа: 

int ThirdPosition (int number)
{
    while (number > 1000) 
        number = number / 10;
    if (number > 99) number = number % 100 % 10;
        else Console.WriteLine("The third position is absent");
    return number;
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdPosition(n));
*/ 

// Задача 3. Показать выходной: 

void Weekend (int num)
{
    if (num == 6 || num == 7) Console.WriteLine("Yes");
    if (num > 1 && num < 6) Console.WriteLine("No");
    if (num < 1 || num > 7) Console.WriteLine("Uncorrect number!");
}

Console.WriteLine("Input a day's number: ");
int day = Convert.ToInt32(Console.ReadLine());
Weekend (day);