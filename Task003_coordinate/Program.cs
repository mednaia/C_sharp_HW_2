Console.WriteLine("Input number of the quarter of coordinate system and press Enter: ");
int x = int.Parse(Console.ReadLine());

if(x == 1)
    Console.WriteLine("X>0 & Y>0");
else if(x == 2)
    Console.WriteLine("X<0 & Y>0");
else if(x == 3)
    Console.WriteLine("X<0 & Y<0");
else if(x == 4)
    Console.WriteLine("X>0 & Y<0");
else
    Console.WriteLine($"Incorrect value.");