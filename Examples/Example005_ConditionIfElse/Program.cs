// See https://aka.ms/new-console-template for more information
Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine()!;
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
 Console.Write("Привет, ");
Console.WriteLine(username);   
}

