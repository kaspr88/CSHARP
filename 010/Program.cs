int a = Console.ReadLine();
int b = Console.ReadLine();
int a = int.Parse(userInput);
int b = int.Parse(userInput);
if (a = b * b)
{
    Console.WriteLine($"{a}квадрат{b}");
}
else if (b = b * b)
{
    Console.WriteLine($"{a} не квадрат{b}");
}
else
{
    Console.WriteLine($"квадрата нет");
}