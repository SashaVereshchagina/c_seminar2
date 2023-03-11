// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели");

int n = int.Parse(Console.ReadLine());

if (n==6 || n==7) Console.WriteLine("Это выходной, детка!");
//else if (n==7) Console.WriteLine("Это выходной, детка!");
else Console.WriteLine("Это не выходной, иди работай");