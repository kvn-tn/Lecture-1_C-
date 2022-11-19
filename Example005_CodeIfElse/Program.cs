Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "tatiana")
{
    Console.WriteLine("Ура, это же Tatiana");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}  