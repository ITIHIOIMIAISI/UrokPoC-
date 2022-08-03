Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "артём")
{
    Console.WriteLine("Братааааан, давно невиделись");
    Console.WriteLine("Как дела ?");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}