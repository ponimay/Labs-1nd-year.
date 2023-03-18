//#1 var 11 laba 17-18
/*
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.WriteLine("Задание: Дан файл, содержащий текст на русском языке и некоторое слово." +
    "\nНайти это слово в тексте и заключить его в круглые скобки." +
    "\nВывести в другой файл и на экран результат.");

string path = @"D:\\str.txt"; 
string stroka = ("Последнюю ночь перед уходом в подземелье Володя ночевал в доме дяди Гриценко. Несколько раз ночью мать подходила к его постели, поправляла одеяло на мальчиках, зажимая себе рот, боясь застонать, заплакать от томившей ее тревоги. Засквозили первые проблески рассвета, и дядя Гриценко, затопав босыми ногами по хате, поднял штору, пуская в комнату холодную муть начавшегося утра. Затем он растолкал крепко спавших ребят. Мальчики, зевая, одевались. Они умылись студеной водой, согнавшей с них зевоту. Сосредоточенно сопя, жевали они холодные лепешки, оставшиеся с вечера. Прощались в темноте. Утренний ветер, поднимавшийся с моря, нес с собой гарь. У входа в каменоломню часовой не пропустил их, не проверив пароля. Перед ними был черный колодец, казавшийся бездонным. Из невидимых недр шел какой-то запах, слышались голоса."); // запишем в файл
string searchText = ("Володя");

File.WriteAllText(path, stroka, Encoding.UTF8);
StreamReader fille = new("D:\\str.txt");

string[] getstr = File.ReadAllText(path, Encoding.UTF8).Split(' ');

foreach (string s in getstr)
{
    if (!s.Contains(searchText))
    {
        string count = "";
        count = getstr[6]; 
        Console.WriteLine("Слово: (" + searchText + ") содержится в тексте");
        fille.Close();
        Console.WriteLine(count);
        string path1 = @"D:\\str1.txt";
        
        File.WriteAllText(path1, count, Encoding.UTF8);
        StreamReader file = new("D:\\str1.txt");
        
        string[] getstr1 = File.ReadAllText(path1, Encoding.UTF8).Split(' ');if (File.Exists(path1)) Console.WriteLine("Проверка файла, его наличие: Да");
        if (getstr1.Contains(searchText))
           Console.WriteLine("Проверка файла, на наличие в тектовом файле: Да");
            
    }
    else Console.WriteLine("Слово: [" + searchText + "] не содержится в тексте");break;
}
Console.ReadKey();
*/
//#2 var 4 laba 17-18

using System.Text;

Console.WriteLine("Задание: Создать в редакторе текстовый файл, каждая строка которого содержит фамилию, имя и номер телефона. " +
    "\nОрганизовать сортировку строк в алфавитном порядке по фамилиям, а если встретились однофамильцы, то по именам.");

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string path = @"D:\\str11.txt";
string stroka = ("Иванов Иван = +7-913-647-87-12\n;Пётр Петрович = +7-914-148-64-73;Григорий Васильев = +7-908-734-18-34\n;Василий Васильев = +7-917-547-90-34\n;");

File.WriteAllText(path, stroka, Encoding.UTF8);
StreamReader fille = new("D:\\str11.txt");

string[] getstr = File.ReadAllText(path, Encoding.UTF8).Split(';');

foreach (var str in (IEnumerable<string>)(from word in getstr
                                          orderby word ascending
                                          select word))
    Console.WriteLine(str);
*/