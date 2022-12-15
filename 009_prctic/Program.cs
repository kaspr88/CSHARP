Console.WriteLine("Введите число");
string userInput = Console.ReadLine() ?? ""; //Конструкция (?? "") убирает желтую ошибку из консоли
int number = int.Parse(userInput);//Метод Parse превращвет меняет тип
int result = (int)Math.Pow(number, 2); //Явное приведение типов (int) Метод (Pow.класс) математические функции
Console.WriteLine($"{number}->{result}");// способ вывести 2 переменные