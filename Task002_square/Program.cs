Console.WriteLine("Input the first number and press Enter: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number and press Enter: ");
int b = int.Parse(Console.ReadLine());
if(a*a == b) 
    Console.WriteLine($"{b} is the square of a number {a}");
else if(b*b == a) 
    Console.WriteLine($"{a} is the square of a number {b}");
else 
    Console.WriteLine($"{a} isn't the square of a number {b} and {b} isn't the square of a number {a}.");

