//#1 var 11 laba 22
/*
using System.Text;
Console.WriteLine("Дан файл Assort, содержащий сведения об игрушках: указывается назва¬ние игрушки, ее стоимость в рублях и " +
    "\nвозрастные границы (например, игрушка может предназначаться для детей от двух до пяти лет)." +
    "\nПолучить названия игрушек, которые подходят детям как четырех лет, так и десяти лет.\n");
Console.WriteLine("Добро пожаловать в магазин игрушек 'Мир Игрушек'. Ознакомьтесь с нашим асортиментом: ");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str123.txt"; string s; string e;
List<string> people = new()
{"\nНазвание игрушки: Юла, Стоимость: 555 рублей, Возрастное ограничение: до 4х лет.",
"\nНазвание игрушки: Кукла, Стоимость: 15.000 рублей, Возрастное ограничение: до 10 лет.",
"\nНазвание игрушки: Спиннер, Стоимость: 100 рублей, Возрастное ограничение: от 2 до 99 лет.",
"\nНазвание игрушки: Паровозик, Стоимость: 700 рублей, Возрастное ограничение: от 5 до 99 лет.",
"\nНазвание игрушки: Машинка, Стоимость: 3.000 рублей, Возрастное ограничение: от 13 до 99 лет."
};people.Sort();
for (int i = 0; i < people.Count; i++)
    Console.WriteLine(people[i]);
var d = string.Join(",", people.ToArray());
Console.WriteLine("\n\nИгрушки, которые подходят детям четырех лет, а также и десяти лет: ");
if (d.Contains("4х"))
{
    s = people[4];
    Console.WriteLine(s);
    File.WriteAllText(path, s, Encoding.UTF8);
}
if (d.Contains("до 10 лет."))
{
    e = people[0];
    Console.WriteLine(e);
    File.WriteAllText(path, e, Encoding.UTF8);
    Console.WriteLine("\nЗадание выполненно!");
    
}
Console.ReadKey();
*/
//#2 var 4 laba 22
using System.Text;
Console.WriteLine("Дан файл Assort, содержащий сведения об игрушках: указывается назва¬ние игрушки, ее стоимость в рублях и " +
    "\nвозрастные границы (например, игрушка может предназначаться для детей от двух до пяти лет)." +
    "\nПолучить названия игрушек, которые подходят детям как четырех лет, так и десяти лет.\n");
Console.WriteLine("Добро пожаловать в магазин игрушек 'Мир Игрушек'. Ознакомьтесь с нашим асортиментом: ");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str123.txt"; string s;
List<string> people = new()
{"\nНазвание игрушки: Мяч, Стоимость: 555 рублей, Возрастное ограничение: до 4х лет.",
"\nНазвание игрушки: Пингвин, Стоимость: 15.000 рублей, Возрастное ограничение: до 10 лет.",
"\nНазвание игрушки: Спиннер, Стоимость: 100 рублей, Возрастное ограничение: от 2 до 99 лет.",
"\nНазвание игрушки: Паровозик, Стоимость: 700 рублей, Возрастное ограничение: от 1 до 99 лет.",
"\nНазвание игрушки: Чебурашка, Стоимость: 3.000 рублей, Возрастное ограничение: от 13 до 99 лет."
}; people.Sort();
for (int i = 0; i < people.Count; i++)
    Console.WriteLine(people[i]);
var d = string.Join(",", people.ToArray());
Console.WriteLine("\n\nАсортимент товаров по вашему запросу (любая игрушка кроме мяча, подходящая ребёнку 3х лет): ");
if (!d.Contains("Мяч"))
{
    s = people[0];
    Console.WriteLine(s);
    File.WriteAllText(path, s, Encoding.UTF8);
}
if (d.Contains("99 лет."))
{
    var result = people.Skip(1);
    foreach (var person in result)
    {
        Console.WriteLine(person);
        File.WriteAllText(path, person, Encoding.UTF8);
    }
}
Console.ReadKey();

//#1 var 4 laba 22
