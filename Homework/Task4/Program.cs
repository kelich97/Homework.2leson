// Напишите программу , которая принимает на вход три числа и выдает максимальное из эти чисел.
Console.WriteLine("Input first number");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int third_number = Convert.ToInt32(Console.ReadLine());
int max = first_number;
if (second_number > max)
{
    max = second_number;
}
if (third_number > max)
{
    max = third_number;
}
Console.WriteLine(max);
