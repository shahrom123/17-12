
var user = new user();


Console.Write("Enter your Username : ");
user.UserName = Console.ReadLine();

Console.Write("Enter your Password : ");
user.Password = Console.ReadLine();

Console.Write("Enter your username : ");
string username = Console.ReadLine();
Console.Write("Enter your password : ");
string password = Console.ReadLine();
user.introduce();
user.Login(username, password);



