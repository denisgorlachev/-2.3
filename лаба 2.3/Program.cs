//Горлачев базовый уровень
Console.WriteLine("Введите число a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
double c = double.Parse(Console.ReadLine());
double min = a;
if (b < min)
    min = b;
if (c < min)
    min = c;
Console.WriteLine("min: " + min);