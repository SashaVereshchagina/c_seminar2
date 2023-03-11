// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

int squareA = a*a;
int squareB = b*b;

if (a==squareB) Console.WriteLine("Число 1 - квадрат числа 2");
else if (b==squareA) Console.WriteLine("Число 2 - квадрат числа 1");
else Console.WriteLine("Ни одно число не является квадратом другого");
