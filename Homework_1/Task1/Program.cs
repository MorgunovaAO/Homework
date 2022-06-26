int a, b; 

Console.Write("Input a first number: "); 
a = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input a second number: "); 
b = Convert.ToInt32(Console.ReadLine()); 

if (a > b) 
{ 
    Console.WriteLine("max = " + a + ", min = " + b); 
} 
else 
{ 
    Console.WriteLine("max = " + b + ", min = " + a); 
} 
