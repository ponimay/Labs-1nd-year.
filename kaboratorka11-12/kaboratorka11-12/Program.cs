//#1 var 11 laba 11-12
/*
Console.WriteLine("Дана строка. Подсчитать количество букв k в последнем ее слове.");
Console.WriteLine("Введите слово: ");
string str;
str = Console.ReadLine();
Console.WriteLine($"Наша 1 Строка: " + str);
int value = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'k')
    {
        value++;
    }
}
Console.WriteLine("Колличество букв k в последнем слове " + value);
*/

Console.WriteLine("В строке между словами вставить вместо пробела запятую и пробел.");
Console.WriteLine("Введите слово:");
string str = Console.ReadLine();
string r = str.Replace(" ", ", ");
Console.WriteLine("\nВидоизменённое предложение: " + r);
Console.ReadLine();
