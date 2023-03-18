//#1 var 4 laba 14
Console.WriteLine("Вычислить произведение площадей трех кругов, радиусы которых равны R, R^2, R^3.");
int R1, R2, R3;
double PI = 3.14;
Console.WriteLine("Введите первый радиус: ");
R1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй радиус: ");
R2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третьий радиус: ");
R3 = int.Parse(Console.ReadLine());


double S1 = (PI * Math.Pow(R1, 2));
double S2 = (PI * Math.Pow(R2, 4));
double S3 = (PI * Math.Pow(R3, 5));
double S4 = S1 * S2 * S3;

Console.WriteLine($"Произведение трёх площадей = {S1}, {S2}, {S3} = {S4} ");










/*
//#2 var 4 laba 14

Console.WriteLine("Даны числа a, b, c. Получить min(a, a + b ) + min ( a, b + c) / 1 + min( a+b*c, b)");
int a, b, c;
Console.WriteLine("Введите а: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c: ");
c = int.Parse(Console.ReadLine());

int f = Math.Min(a, a + b) + Math.Min(a, b + c) / 1 + Math.Min(a + b * c, b);
Console.WriteLine("Ответ:"+ f);
*/