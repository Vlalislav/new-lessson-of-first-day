Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.Write("Привет Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}