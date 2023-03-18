//#1 var 11
/*
Console.WriteLine("Программа для вычисления значения выражения по формуле.");

double x, y;
Console.WriteLine("Введите х: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y: ");
y = Convert.ToInt32(Console.ReadLine());

double d = (Math.Pow(1 + 1 / Math.Pow(x, 2), x)) - 12 * Math.Pow(x, 2) * y;
Console.WriteLine($"Ответ: {d}");
*/
//#2 var 11
/*
Console.WriteLine("Программа для вычисления значения функции");

Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
double F;
if (x <= 3.5)
{
    F = (4 * Math.Pow(x, 2) + 2 * x - 19);
    Console.WriteLine(F);
}      
else
{
    F = -(2 * x) / (-4 * x + 1);
    Console.WriteLine(F);
}
*/
//#3 var 11
/*
Console.WriteLine("Введите номер измерения (1-5)");
Console.WriteLine("Еденица измерения введеных вами данных. Где, 1 — дециметр; 2 — километр; 3 — метр; 4 — миллиметр; 5 — сантиметр");
Console.WriteLine("Введите значение: ");
double L = Double.Parse(Console.ReadLine());

switch (L)
{
    case 1: L *= 0.1; break;
    case 2: L *= 1000; break;
    case 4: L *= 0.001; break;
    case 5: L *= 0.01; break;
}
Console.WriteLine($"{L} метров");

*/