Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРААА! Это же Маша)))");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}