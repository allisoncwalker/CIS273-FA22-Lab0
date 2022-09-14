// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vector.Vector v1 = new Vector.Vector();
v1.X = 4.5;
v1.Y = 3;

Vector.Vector v2 = new Vector.Vector();
v2.X = 2.2;
v2.Y = 5;

Vector.Vector result = v1.Add(v2);
Vector.Vector result1 = v1.Subtract(v2);
double result2 = v1.Dot(v2);
double result3 = v1.AngleBetween(v2);

Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);