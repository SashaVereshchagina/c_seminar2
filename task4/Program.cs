// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Сколько измерений в пространстве, расстояние между точками которого вы хотите найти?");
int n = int.Parse(Console.ReadLine());

if (n==2) {
    Console.WriteLine("Введите координату точки A по оси X: ");
    int xA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки A по оси Y: ");
    int yA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату точки B по оси X: ");
    int xB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки B по оси Y: ");
    int yB = int.Parse(Console.ReadLine());

    double D = Math.Sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB));
    Console.WriteLine("Расстояние между точками = ");
    Console.Write(D);
}

else {
    Console.WriteLine("Введите координату точки A по оси X: ");
    int xA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки A по оси Y: ");
    int yA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки A по оси Z: ");
    int zA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату точки B по оси X: ");
    int xB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки B по оси Y: ");
    int yB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату точки A по оси Z: ");
    int zB = int.Parse(Console.ReadLine());

    double D = Math.Sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB) + (zA-zB)*(zA-zB));
    Console.WriteLine("Расстояние между точками = ");
    Console.Write(D);
}
