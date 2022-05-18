Console.WriteLine("Input the name of the weekday add press Enter: ");
string day = Console.ReadLine();
if (day.ToLower() == "monday") Console.WriteLine("1");
if (day.ToLower() == "tuesday") Console.WriteLine("2");
if (day.ToLower() == "wednesday") Console.WriteLine("3");
if (day.ToLower() == "thursday") Console.WriteLine("4");
if (day.ToLower() == "friday") Console.WriteLine("5");
if (day.ToLower() == "saturday") Console.WriteLine("6");
if (day.ToLower() == "sunday") Console.WriteLine("7");
else 
{
    Console.WriteLine("Incorrect name");
}