﻿// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());

if (n==1) Console.WriteLine("Диапазон возможных координат: x - от 0 до +бесконечности, y - от 0 до +бесконечности");
if (n==2) Console.WriteLine("Диапазон возможных координат: x - от -бесконечности до 0, y - от 0 до +бесконечности");
if (n==3) Console.WriteLine("Диапазон возможных координат: x - от -бесконечности до 0, y - от -бесконечности до 0");
if (n==4) Console.WriteLine("Диапазон возможных координат: x - от 0 до +бесконечности, y - от -бесконечности до 0");
