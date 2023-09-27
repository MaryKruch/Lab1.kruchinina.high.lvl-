//Вариант 4. Уровень высокий
Console.Write("Ведите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Ведите x:");
double x = double.Parse(Console.ReadLine());
double F = (Math.Sqrt(Math.Pow((2 + y), 2) + Math.Pow(Math.Sqrt(Math.Sin(y + 5)), 1 / 7.0))) / Math.Log(x + 1) - Math.Pow(y, 3);
Console.WriteLine($"F = {F:F2}");