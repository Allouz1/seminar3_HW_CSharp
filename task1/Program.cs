int number = ReadInt("Введите пятизначное число: ");
string numberStr = number.ToString();

if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
{
    Console.WriteLine("Число полиндром");
}
else if (numberStr[0] != numberStr[4] && numberStr[1] != numberStr[3])
{
    Console.WriteLine("Число не полиндром");
}
// Выдаёт ошибку не могу понять в чём проблема
// else if (number < 9999 && number > 10000)
// {
//     Console.WriteLine("Не верно введено число");
// }

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
