int n, current; 

Console.Write ("Input a number: "); 
n = Convert.ToInt32(Console.ReadLine()); 

current = 2; 

while (current <= n) 
{ 
    if (current % 2 == 0) 
        Console.Write(current + " "); 
    current ++; 
} 