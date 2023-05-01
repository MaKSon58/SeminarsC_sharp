// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine()); - считывание с консоли и перевод в нужный нам тип данных.
// Console.WriteLine($"You input {{{num}}} number"); - внедрение переменной в текст.

//Task1. Запросить число и вывести его квадрат.

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Quaq of {num} -> {num*num}");

//Task2. Является ли первое число квадратом второго?

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} не является квадратом {num2}");
// }

//Task3. Напишите программу, которая принимает на вход число N, на выходе получаем последовательность от  -N до N.

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// if(n<0) Console.WriteLine("Invalid input N");

// int count = n*(-1);
// while(count <= n)
// {
//     Console.Write(count+ " ");
//     count++;
// }

//Task4. На вход принимаем 3х значное число, вывести последнюю цифру данного числа.

// Console.WriteLine("Input three-digit number");
// int n = Convert.ToInt32(Console.ReadLine());
// //int ed = n % 10;
// Console.WriteLine($"Last digit of {n} -> {n%10}");

int num = 123;
string numS = Convert.ToString(num);
Console.WriteLine(numS);
Console.WriteLine(numS.GetType());