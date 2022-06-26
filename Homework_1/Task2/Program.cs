int a, b, c, max; 

Console.Write("Input a first number: "); 
a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a second number: "); 
b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a third number: "); 
c = Convert.ToInt32(Console.ReadLine()); 

max = a; 

if (b > max) 
{ 
    max = b; 
} 

if (c > max) 
{ 
    max = c; 
} 

Console.WriteLine("max = " + max); 