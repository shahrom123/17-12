
class user
{
    public string UserName;
    public string Password;

    public void introduce(){
        System.Console.WriteLine(" I am Shahrom ");
    }
    public void Login(string username, string password)
    {
        if(username == UserName && password == Password) {
            System.Console.WriteLine(" Welcome ");
        }
        else{
            System.Console.WriteLine(" Wrong password ");
        }
    }
}