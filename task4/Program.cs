// Найти максимальное из трех чисел

using System;

int max;
Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int third = Convert.ToInt32(Console.ReadLine());
if (first > second) {
    max = first;
} else
    max = second;
if (third > max) {
    max = third;
}
Console.WriteLine($"{first}, {second}, {third} -> {max}");
