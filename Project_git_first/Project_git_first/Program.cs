Console.WriteLine("right-angled triangle hypotenuse");

Console.WriteLine("insert the lenght side");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("insert the height side");
double b = double.Parse(Console.ReadLine());

double i = Math.Sqrt(a * a + b * b);

Console.Write("lenght side: ");
Console.WriteLine(a);
Console.Write("height side: ");
Console.WriteLine(b);

Console.WriteLine(i);
