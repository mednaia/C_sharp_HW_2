Console.WriteLine("Input the number of the weekday add press Enter: ");
int num = int.Parse(Console.ReadLine());

if(num >= 1 && num <= 5) Console.WriteLine("It's not  day off.");
else if(num > 5 && num < 8) Console.WriteLine("It's weekend!");
else if(num > 7) Console.WriteLine("Incorrect number");