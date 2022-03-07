// Показать четные числа от 1 до N

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} ->");
int i = 0;
while (i < N - 3) {
    i = i + 2;
    Console.Write($" {i},");
}
if (N > 1) {
    Console.Write($" {i + 2}");
} else {
    Console.Write(" null");
}
