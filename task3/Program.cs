int number = ReadInt("Введите число: ");
int i = 1;
while(i <= number)
{   
    Console.Write(Sqr(i) + " ");
    i++;
}

int Sqr(int a)
{
    return a * a * a;
}



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}