//#1 var 11 laba 7-8
/*
Console.WriteLine("Hайти среднее значение элементов заданного столбца.");

Console.WriteLine("Введите a: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[n, m]; 
int[] sum = new int[m];
Random ran = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i = 0; i < m; i++)
{
    Console.Write("\nСреднее значение первого столбца: " + (sum[i] / n) + ". ");
    return;
}
*/
//#2 var 4 laba 7-8
Console.WriteLine("Записать в одномерный массив  элементы заданного столбца матрицы.\n");
Console.WriteLine("Введите a: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
int[] sum = new int[m];
Random ran = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[j] = arr[j, i];
    }
}
for (int i = 0; i < m; i++)
{
    Console.Write($"\nМассив последнего столбца:{sum[i]}.");
}
int value = 0;
Console.WriteLine($"Колличество букв k в последнем слове: {value}");

//dop.zadanie,#2 var 11 laba 7-8
/*
Console.WriteLine("Все элементы, сумма индексов которых четна заменить на -1.");
Random R = new Random();
Console.WriteLine("Введите \"некоторое число Х\": ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество строк и столбцов массива: ");
int[,] mass = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())]; // Вводим размер массива
// Далее заполняем его и выводим
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (((i + j) <= x) & ((i + j) % 2 == -1)) // Если элемент с четной суммой индексов, не превышающей числа X
            mass[i, j] = -1; // Заполняем нулём
        else
            mass[i, j] = R.Next(1, 9);   // Заполняем массив рандомами
        Console.Write($" {mass[i, j]}"); // Выводим массив
    }
    Console.WriteLine();
}
*/


