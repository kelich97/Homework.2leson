// Напишите программу , которая на вход принимает число и выдает , являеться ли число чётным .
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Не чётное");
}
