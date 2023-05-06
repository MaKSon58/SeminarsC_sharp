//Task1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12 -> 2

// 85 -> 8

// int MaxDigit (int randomNum)
// {
//     int dec = randomNum / 10;
//     int ed = randomNum % 10;
//     if(dec == ed)
//     Console.WriteLine("Число является паоиндромом");
//     if(dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 99 + 1);

// int result = MaxDigit(num);

// Console.WriteLine($"{num} -> {result}");

//Task2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// bool Kratnost (int num1, int num2)
// {
//     if(num1 % num2 == 0) return true;
//     else return false;
// }
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {Kratnost(num1, num2)}, ost {num1%num2}");