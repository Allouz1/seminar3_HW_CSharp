int x1 = ReadInt("Введите координату X точки A: ");
int y1 = ReadInt("Введите координату Y точки A: ");
int z1 = ReadInt("Введите координату Z точки A: ");
int x2 = ReadInt("Введите координату X точки B: ");
int y2 = ReadInt("Введите координату Y точки B: ");
int z2 = ReadInt("Введите координату Z точки B: ");
double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
Console.WriteLine(distance);



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

