Console.Write("Введите имя пользователя: ");
string? name = Console.ReadLine();

if(name?.ToLower() == "Маша")
{
Console.WriteLine("Ура, Это же Машка"); 
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}