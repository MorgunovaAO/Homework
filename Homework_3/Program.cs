// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

void Palindrom(int num)
{
    int ed = num % 10;
    int des = (num % 100)/10;
    int thousand = (num / 1000) % 10;
    int tenthousand = num / 1000 / 10;

    if (ed == tenthousand && des == thousand) Console.WriteLine ("True");
    else Console.WriteLine ("False");
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
/*
void Cub(int num)
{
    int current = 1;
    while (current <= num)
    {
        int cub = current * current * current;
        Console.Write(cub + " ");
        current++;
    }
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cub(n);
*/