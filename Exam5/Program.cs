Console.Write("Input name of user: ");
string? username= Console.ReadLine();
if(username?.ToLower() == "викуся")
{
    Console.WriteLine("Ura, this is Викуся");
}
else
{
    Console.WriteLine($"Hallo, {username}");
}

