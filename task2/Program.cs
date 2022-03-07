// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
if (first == second) {
    Console.WriteLine($"Оба числа равны {first}");
} else if (first > second) {
    Console.WriteLine($"Первое число больше: {first} > {second}");
} else {
    Console.WriteLine($"Второе число больше: {first} < {second}");
}