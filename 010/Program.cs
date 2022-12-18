Console.WriteLine("Введите первое число");
String userInputOne = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число");
String userInputTwo = Console.ReadLine() ?? "";
int a = int.Parse(userInputOne);
int b = int.Parse(userInputTwo);
if (a == b * b)
{
    Console.WriteLine($"{a}квадрат{b}");
}
else if (b == a * a)
{
    Console.WriteLine($"{b} не квадрат{a}");
}
else
{
    Console.WriteLine($"квадрата нет");
}