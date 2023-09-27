Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(y >= -x + 1 && y <= x + 1 && y >= x - 1 && y <= -x + 3);