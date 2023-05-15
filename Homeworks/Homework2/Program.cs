// Task10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(int num)
{
    int dec = (num / 10) % 10;
    return dec;
}

Console.WriteLine("Input three-digit number");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    Console.WriteLine($"{num} -> {SecondNumber(num)}");
}
else
{
    Console.WriteLine("Error! Input three-digit number");
}

