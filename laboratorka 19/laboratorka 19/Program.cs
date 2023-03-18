//#1 var 11 laba 19
/*
using System.Text;
Console.WriteLine("Задание: Записать в файл f последовательного доступа N натуральных чисел с помощью генератора случайных чисел." +
                  "\nВывести на экран  все компоненты файла f, которые кратны К.\n");
Console.WriteLine("Добро пожаловать в программу 'Делится ли моё число на рандомное?'");
string path = @"D:\\str111.txt";string path1 = @"D:\\str1111.txt";
Random r = new();
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
using (StreamWriter sw = File.CreateText(path))
  {
    for (int i = 0; i < 100; i++) sw.WriteLine(r.Next(0, 100));
  }

using (StreamReader sr = File.OpenText(path))
{
    Console.WriteLine("\nВведите число, на которое хотите поделить рандомные числа: ");
    int k = 0;k = int.Parse(Console.ReadLine());
    if (k == 0)
    {
      Console.WriteLine($"На {k} делить нельзя!"); File.Delete(path1);return;
    }
    
using StreamWriter sw = File.CreateText(path1);

    while (sr.Peek() != -1)
    {
      int n = int.Parse(sr.ReadLine());
      if (n % k == 0)
       {
        sw.WriteLine(n.ToString());
        Console.WriteLine($"\nИз 100 чисел, число: {n} делится на {k}.");
       }
       else if (n % k > n) Console.WriteLine($"На ваше число {k} не нашлось чисел делящиеся на него.");
    }
}
Console.WriteLine("\nВсе операции завершены!");
Console.ReadKey();
*/
//#2 var 4 laba 19
/*
using System.Text;

Console.WriteLine("Задание: Сформировать файл о студентах одного курса (фамилия, пол, год рождения, месяц рождения). " +
    "\nИспользуя сформированный файл, вывести на экран фамилии студентов мужского пола, родившихся летом (июнь, июль, августа).\n");
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str2.txt";string fam = ""; string pol = ""; string mesRod = ""; string m = "Мужской"; string mesI = "Июнь"; string mesIl = "Июль"; string Av = "Август.";
List<string> people = new()
{"Фамилия: Иванов.И.А, Пол: Мужской, Год Рождения: 1990, Месяц Рождения: Январь.",
"Фамилия: Пугачёва.Э.А, Пол: Женский, Год Рождения: 1981, Месяц Рождения: Сентябрь.",
"Фамилия: Галкин.М.А, Пол: Мужской, Год Рождения: 2001, Месяц Рождения: Июнь.",
"Фамилия: Петрова.Е.В, Пол: Женский, Год Рождения: 2000, Месяц Рождения: Август.",
"Фамилия: Сидоров.П.Т, Пол: Мужской, Год Рождения: 2009, Месяц Рождения: Октябрь."
};

Console.WriteLine("Введите фамилию: ");
fam = Console.ReadLine();
Console.WriteLine("Введите ваш пол (Мужской/Женский): ");
pol = Console.ReadLine();
Console.WriteLine("Введите ваш месяц рождения: ");
mesRod = Console.ReadLine();


if (pol == m)
{
    if (mesRod == (mesI) || (mesRod == mesIl) || (mesRod == Av))
    {
        Console.WriteLine("wad");
    }
    
    else Console.WriteLine("К сожалению, вы нам не подходите!");
}

/*
for (int i = 0; i < people.Count; i++)
{
    string? person = people[i];
    if (person.Contains("Июнь.") || (person.Contains("Июль.")) || (person.Contains("Август.")))
    {
        if (person.Contains("Мужской"))
        {
            Console.WriteLine("Студент/ы подходящие под критерии: \n");
            Console.WriteLine("1) " + person);
            string a = person;
            File.WriteAllText(path, a, Encoding.UTF8);
            File.ReadAllText(path, Encoding.UTF8);
            return;
        }
        else Console.WriteLine("Студента подходящий под критерии нет.");
        Console.ReadKey();
    }
}
*/
