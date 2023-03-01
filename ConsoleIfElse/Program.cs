Console.Write("Введите свое имя ");
string username = Console.ReadLine();

if(username.ToLower() == "ева")
{
    Console.WriteLine("Приветствую Вас, императрица Ева");
}
else
{
    Console.Write("Привет, плебей ");
    Console.Write(username);
}