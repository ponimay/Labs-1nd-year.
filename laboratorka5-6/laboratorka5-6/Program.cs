//#1 var 11
/*
Console.WriteLine("Введите размерность массива");
int r;
r = Convert.ToInt32(Console.ReadLine());
int[,] m = new int[r, r];
int sum = 0;
int summa = 0;
Random R = new Random();
for (int i = 0; i < m.GetLength(0); i++)
{
    for (int j = 0; j < m.GetLength(1); j++)
    {
        m[i, j] = R.Next(-5, 5);
        Console.Write(m[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m.GetLength(0); i++)
{
    
    sum = 0;
    for (int j = 0;j < m.GetLength(1); j++)
    {
        
        sum += m[i, j];
        
    }
Console.WriteLine("Сумма " + (i + 1) + " столбца равна1 " + sum);
}
*/
/*
int n, m, sum1=0, sum2=0;
Console.WriteLine("Введите n-строк и m-столбцов!");
Console.Write("n:= ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("m:= ");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] k = new int[n, m];
Random r = new Random();        //заполняем матрицу случайными числами 
for (int i = 0; i < n; i++) 
{
for (int j = 0; j < m; j++) 
{
k[i, j] = r.Next(-5, 5);    //каждый элемент принимает значение от -5 до +5
Console.Write("{0} ", k[i, j],"\t");
}
Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
if (k[i, j] < 0)
{
sum1 += k[j, i];//находим сумму всех элементов столбца
}
Console.WriteLine();
Console.WriteLine("Сумма  строки равна " + sum1);     //выводим сумму строки
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
if (k[i, j] < 0)
{
sum2 += k[j, i];//находим сумму всех элементов столбца
}
}
Console.WriteLine();
Console.WriteLine("Сумма " + (i + 2) + " столбца равна " + sum2);     //выводим сумму столбца
}
*/
/////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Найти сумму отрицательных элементов четных столбцов матрицы В размером 4х4.");
Random rand = new Random();
Console.WriteLine("Введите размерность матрицы AxB :");
int M = int.Parse(Console.ReadLine());
int[,] matr = new int[M, M];
int sum = 0;
for (int j = 0; j < M; j++)
{
    for (int m = 0; m < M; m++)
    {
        matr[j, m] = rand.Next(-5, 5);
        Console.Write(matr[j, m] + "\t");
        if ((j + 1) % 2 == 0)
        {
            if (matr[j, m] < 0) ;
        }
    }
    Console.WriteLine();
    for (int i = 0; i < M; i++)
    {
    sum += matr[j, i];
    }
}
Console.Write($"Сумма четных строк матрицы = {sum}");
*/
//#2 var 11
Console.WriteLine("Вычисление sin(x) по формуле: (1 + sin0,1)(1 + sin0,2) ... (1 + sin10)");
Console.Write("\nВведите угол в градусах = ");
double a = Convert.ToDouble(Console.ReadLine());
double x, y;
x = a * Math.PI / 180;
Console.WriteLine($"Угол в радианах = {x}.");

