Console.WriteLine("Введите координаты первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double distance (double x1, double y1, double z1, double x2, double y2, double z2){
double result = Math.Sqrt((Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)));
return result;
}
double r = distance (x1,x2,y1,y2,z1,z2);
Console.WriteLine($"Длина вектора равна {r}");