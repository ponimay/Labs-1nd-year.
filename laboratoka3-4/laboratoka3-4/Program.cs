//#1 var 4 laba 3-4
/*
Console.WriteLine("Введите последовательность чисел!");
int[] a = new int[5];
for (int i = 0; i < a.Length; i++)
    a[i] = int.Parse(Console.ReadLine());

for (int i = 1; i < a.Length; i++)
{
    if (a[i] < a[i - 1])
    {
        Console.WriteLine("Не возрастающая.");
        break;
    }
    else
    {
        Console.WriteLine("Возврастающая.");
        break;
    }
}
Console.ReadKey();
*/
//#2 var 4 laba 3-4
/*
int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next();

Console.WriteLine("Введите натуральные числа: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % m > 0 && array[i] % m < m - 1)
    {
        Console.WriteLine(array[i]);

    }
    else
    {
        Console.WriteLine("Чисел, которые входят в диапозон нет.");
        break;
    }
}
Console.ReadKey();
*/
/*
//#3 var 11 laba 3-4
Console.WriteLine("Сумма положительных элементов массива из 10 чисел.");
Random R = new Random();
int[] m = new int[10];
int sum = 0;
Console.WriteLine("\nМассив чисел:");
for (int i = 0; i < m.Length; i++)
{
    m[i] = R.Next(-10, 11);
    Console.Write(m[i] + ";\t");
    if (m[i] > 0)
        sum += m[i];
}
Console.WriteLine($"\nСумма положительных: {sum}");
*/