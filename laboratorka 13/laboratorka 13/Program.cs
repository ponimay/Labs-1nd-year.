//#1 laba13 var 4
/*
using System.Text.RegularExpressions;
Console.WriteLine("Для заданного текста определить длину содержащейся в нем максимальной серии символов, отличных от букв. ");
string[] test = { "Привет." , "Это моё 1 сообщение." , "И ты наверняка, его не увидешь"};

int ind = 0;
int MaxCh = 0;
int i = 0;
foreach (var item in test)
{
    string newStr = Regex.Replace(item, "[ 0-9 ]", string.Empty);
    Console.WriteLine(newStr + " количество букв " + newStr.Length);
    if (MaxCh < newStr.Length)
    {
        MaxCh = newStr.Length;
        ind = i;
    }

    i++;
}

Console.WriteLine(test[ind]);
*/

//#2 laba13 var 4
Console.WriteLine("В заданный непустой текст входят только цифры и буквы. " +
    "\nОпределить, удовлетворяет ли он следующему свойству: текст является записью десятичного числа, кратного 4. ");
Console.WriteLine("Введите текст: ");
char[] m = Console.ReadLine().ToCharArray();
string q = string.Empty;
for (int i = 0; i < m.GetLength(0); i++)
{
    if (char.IsDigit(m[i]))
    {
        q += m[i];
    }
}
int x = int.Parse(q);
if (x % 4 == 0)
{
    Console.WriteLine($"\nЧисло {x}, кратно 4.");
}
else
{ 
    Console.WriteLine($"\nЧисло {x}, НЕ кратно 4.");
}
Console.ReadKey();