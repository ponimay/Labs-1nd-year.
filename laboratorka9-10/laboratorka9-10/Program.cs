//#1 var 11 laba 9-10
/*
Console.WriteLine("Даны целые числа от 1 до 40. Получить случайным образом 5 чисел из этого множества.");
Random rnd = new Random();

int value = rnd.Next(1, 40);  
int value1 = rnd.Next(1, 40); 
int value2 = rnd.Next(1, 40); 
int value3 = rnd.Next(1, 40);
int value4 = rnd.Next(1, 40);

Console.WriteLine("Рандомные 5 чисел: ");
Console.WriteLine(value);
Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3);
Console.WriteLine(value4);
*/

//#2 var 4 laba 9-10
using System;
Console.WriteLine("Имеется список класса (все имена различны). Определить, есть ли в классе человек, который побывал в гостях у всех." +
    "\n(Для каждого ученика составить множество побывавших у него в гостях друзей, сам ученик в это множество не входит.) ");

Console.Write("\nСписок класса: \n");
Console.Write("Людмила, Татьяна, Елена, Ксюша, Анастасия, Марина, Евгения, Василий, Никита, Андрей \n");
string a = ("Людмила, Татьяна, Елена, Ксюша, Анастасия, Марина, Евгения, Василий, Никита, Андрей");
Console.WriteLine("\nВ гости к Людмиле пришли: ");
Console.WriteLine("Татьяна, Елена, Ксюша, Анастасия.");
string b = ("Татьяна, Елена, Ксюша, Анастасия.");
Console.WriteLine("\nВ гости к Татьяне пришли: ");
Console.WriteLine("Евгения, Василий, Никита.");
string c = ("Евгения, Василий, Никита.");
Console.WriteLine("\nВ гости к Анастасии пришли: ");
Console.WriteLine("Марина, Евгения, Василий.");
string d = ("Марина, Евгения, Василий.");

bool z = b.Contains("Андрей");
bool q = c.Contains("Андрей");
bool x = d.Contains("Андрей");
if ( z == true)
{
    Console.WriteLine($"В гости к Людмиле пришёл Андрей {z}");
}

else if ( q == true)
{
    Console.WriteLine($"В гости к Татьяне пришёл Андрей {z}");
}

else if ( x == true)
{
    Console.WriteLine($"В гости к Анастасии пришёл Андрей {z}");
}    
else if( x == false)
{
    Console.WriteLine($"\nВ гости к Людмиле, Татьяне, Анастасии НЕ пришёл Андрей {z}");
}

