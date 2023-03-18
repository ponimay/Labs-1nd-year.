//#1(a) var 4 laba 15-16
/*
Console.WriteLine("Даны две переменные x, y (вещественные). Используя процедуру нахождения наименьшего из двух значений, найти наименьшее из а) x,y     б) x+y, x*y, 0.5    в) 2x, |x-y|, 4.5, [(x+y)/3]");
double x, y, c;
Console.WriteLine("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
y = int.Parse(Console.ReadLine());
c = Math.Min(x,y);

Console.WriteLine($"а) Минимальное число из {x} и {y} = {c}");
*/
//#1(b) var 4 laba 15-16
/*
Console.WriteLine("Даны две переменные x, y (вещественные). Используя процедуру нахождения наименьшего из двух значений, найти наименьшее из а) x,y     б) x+y, x*y, 0.5    в) 2x, |x-y|, 4.5, [(x+y)/3]");
double x, y, b1, b2, b3;
Console.WriteLine("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
y = int.Parse(Console.ReadLine());

b1 = x + y;
b2 = x * y;
b3 = 0.5;

if ((b1 < b2) && (b1<b3)) Console.WriteLine($"б) Минимальное число из {b1}, {b2} и {b3} = {b1}");
else if ((b2 < b1) && (b2 < b3)) Console.WriteLine($"б) Минимальное число из {b1}, {b2} и {b3} = {b2}");
else Console.WriteLine($"б) Минимальное число из {b1}, {b2} и {b3} = {b3}");
*/
//#1(c) var 4 laba 15-16
/*
Console.WriteLine("Даны две переменные x, y (вещественные). Используя процедуру нахождения наименьшего из двух значений, найти наименьшее из а) x,y     б) x+y, x*y, 0.5    в) 2x, |x-y|, 4.5, [(x+y)/3]");
double x, y, b1, b2, b3, b4;
Console.WriteLine("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y: ");
y = int.Parse(Console.ReadLine());

b1 = 2 * x;
b2 = Math.Abs(x-y);
b3 = 4.5;
b4 = (x + y) / 3;

if ((b1 < b2) && (b1 < b3) && (b1 < b4)) Console.WriteLine($"\nс) Минимальное число из {b1}, {b2}, {b3} и {b4} = {b1}");
else if ((b2 < b1) && (b2 < b3) && (b2 < b4)) Console.WriteLine($"\nс) Минимальное число из {b1}, {b2}, {b3} и {b4} = {b2}");
else if ((b3 < b1) && (b3 < b2) && (b3 < b4)) Console.WriteLine($"\nс) Минимальное число из {b1}, {b2}, {b3} и {b4} = {b3}");
else Console.WriteLine($"\nс) Минимальное число из {b1}, {b2}, {b3} и {b4} = {b4}");
*/
//#2 var 4 laba 15-16
Console.WriteLine("Даны длины сторон треугольника a, b, c. Найти медианы треугольника. " +
    "\nДля вычисления медианы проведенной к стороне а, использовать формулу 0,5√2b^2 + 2c^2 - a^2." +
    "\nВычисление медианы оформить в виде процедуры. ");

double a, b, c, ma, mb, mc;
Console.WriteLine("\nВведите а: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("\nВведите b: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("\nВведите c: ");
c = int.Parse(Console.ReadLine());
ma = 0;mb = 0;mc = 0;
void midA()
{
    
    if ((a < b + c) || (b < a + c) || (c < a + b))
    ma = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(c, 2) - Math.Pow(a, 2)); Console.WriteLine("\n\nа:"+ ma);
    if ((a >= b + c) || (b >= a + c) || (c >= a + b)) Console.WriteLine("Ошибка: Это не треугольник, повторите ввод");
    else if ((ma == 0) || (mb == 0) || (mc == 0)) return;
}

void midB()
{
    
    if ((a < b + c) || (b < a + c) || (c < a + b))
    mb = 0.5 * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(c, 2) - Math.Pow(b, 2)); Console.WriteLine("\nb:" + mb);
    if ((a >= b + c) || (b >= a + c) || (c >= a + b)) Console.WriteLine("Ошибка: Это не треугольник, повторите ввод");
    else if ((ma == 0) || (mb == 0) || (mc == 0)) return;
}

void midC()
{
    
    if ((a < b + c) || (b < a + c) || (c < a + b))
    mc = 0.5 * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(b, 2) - Math.Pow(c, 2)); Console.WriteLine("\nc:" + mc);
    if ((a >= b + c) || (b >= a + c) || (c >= a + b)) Console.WriteLine("Ошибка: Это не треугольник, повторите ввод");
    else if ((ma == 0) || (mb == 0) || (mc == 0)) return;
}
Console.Write("\nМедиана треугольника проведённая к стороне a, b, c: "); midA();midB();midC();


