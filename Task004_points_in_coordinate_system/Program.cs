char choice;
Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("1. Distance between two points in the plane (2D).");
Console.WriteLine("2. Distance between two points in the space (3D).");
Console.WriteLine("Choose the system of coordinates (1 or 2) and press Enter: ");
choice = Convert.ToChar(Console.ReadLine());
switch (choice)
    {
        case '1':
            Console.WriteLine("Input X coordinate of the first point and press Enter: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y coordinate of the first point and press Enter: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input X coordinate of the second point and press Enter: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y coordinate of the second point and press Enter: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            distance = Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),2);
            Console.WriteLine($"Distance between two points in the plane (2D) = {distance}");
            break;
        case '2':
            Console.WriteLine("Input X coordinate of the first point and press Enter: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y coordinate of the first point and press Enter: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Z coordinate of the first point and press Enter: ");
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input X coordinate of the second point and press Enter: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y coordinate of the second point and press Enter: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Z coordinate of the second point and press Enter: ");
            z2 = Convert.ToDouble(Console.ReadLine());
            distance = Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)),2);
            Console.WriteLine($"Distance between two points in the space (3D) = {distance}");
            break;
        default:
            Console.WriteLine("Incorrect value");
            break;
    }