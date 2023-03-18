//#1 var 4 laba 20-21
/*
using System.Text;
Console.WriteLine("Задание: Дан файл, компоненты которого целые числа." +
    "Найти наибольшее число и вставить после него заданное число.");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str22.txt"; int a = 0; int b = 0; int c = 0; 
List<int> list = new () { 10, 84, 76, 72, 50, 27, 32, 43, 11, 81 };
for (int i = 0; i < list.Count; i++)
    Console.Write(list[i] + "\t");
a = list.Max();
Console.WriteLine($"\nМаксимальный элемент {a}\n");
Console.Write($"Введите число, которое хотите вставить после числа {a}: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("\nИтоговый массив чиел: ");
list.Insert(2, b); 
for (int i = 0; i < list.Count; i++)
    Console.WriteLine(list[i]); 
var d = string.Join(", ", list.ToArray());
File.WriteAllText(path, d, Encoding.UTF8);  
File.ReadAllText(path, Encoding.UTF8);
Console.WriteLine("Задание выполненно!");
Console.ReadKey();
*/
//#2 var 4(11) laba 20-21
/*
using System.Text;
Console.WriteLine("Файл содержит сведения  о работающих на фабрике: фамилия, имя, отчество, адрес (улица, дом, квартира) " +
    "\nи дата поступления на работу (месяц, год).");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str222.txt";
List<string> people = new()
{"\nФамилия: Иванов Инокентий Андреевич, Пол: Мужской, Дата рождения: 01.10.1990, Адрес проживания: г.Воронеж ул.Московский пр-кт 3, кв #10, Дата поступления на работу: 10.18.2020.",
"\nФамилия: Пугачёва Оксана Андреевна, Пол: Женский, Дата рождения: 22.01.2006, Адрес проживания: г.Москва ул Пешкова 10, кв #20, Дата поступления на работу: 31.02.2035.",
"\nФамилия: Галкин Максим Алексеевич, Пол: Мужской, Дата рождения: 12.07.2000, Адрес проживания: г.Тамбов ул Матроса 17, кв #1, Дата поступления на работу: 30.12.2022.",
"\nФамилия: Петрова Лариса Викторовна, Пол: Женский, Дата рождения: 10.09.2001, Адрес проживания: г.Анапа ул Победы 16, кв #9, Дата поступления на работу: 09.09.2021.",
"\nФамилия: Сидоров Пётр Иванович, Пол: Мужской, Дата рождения: 07.06.1999, Адрес проживания: г.Калининград ул 40 лет Октября 90, кв #30, Дата поступления на работу: 10.07.2009."
};
people.Sort();
for (int i = 0; i < people.Count; i++)
    Console.WriteLine(people[i]);
var d = string.Join(", ", people.ToArray());
File.WriteAllText(path, d, Encoding.UTF8);
File.ReadAllText(path, Encoding.UTF8);
Console.WriteLine("\nЗадание выполненно!");
Console.ReadKey();

*/