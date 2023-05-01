//Task2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine($"max = {a}");
//     Console.WriteLine($"min = {b}");
// }
// else
// {
//     Console.WriteLine($"max = {b}");
//     Console.WriteLine($"min = {a}");
// }

//Task4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int c = Convert.ToInt32(Console.ReadLine());
// int max1; int max2;

// if(a > b)
// {
//     max1 = a;
// }
// else
// {
//     max1 = b;
// }

// if(b > c)
// {
//     max2 = b;
// }
// else
// {
//     max2 = c;
// }

// if(max1 > max2)
// {
//     Console.WriteLine($"max = {max1}");
// }
// else
// {
//     Console.WriteLine($"max = {max2}");
// }

//Task6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// {
//     Console.WriteLine($"{num} is even");
// }
// else
// {
//     Console.WriteLine($"{num} is odd");
// }

//Task8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

if(n <= 1) Console.WriteLine("Invalid input N");

int count = 1;
while(count <= n)
{
    if(count % 2 == 0)
    Console.Write(count+ " ");
    count++;
}