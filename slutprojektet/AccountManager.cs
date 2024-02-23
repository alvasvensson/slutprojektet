namespace slutprojektet;

public class AccountManager
{
    List<Account> accounts = new List<Account>();
    //Läsa in JSOn filen och lägga in alla objekt i den till accountslistan

    public void LogIn()
    {
        Console.WriteLine("Username?");
        //checka om det användarnamnet finns
        foreach (Account a in accounts)
        {

        }

        Console.WriteLine("password?");
        // kolla om lösenordet matcher det angivna användarnamnets lösenord


    }
    public void CreateAccount()
    {
        Console.WriteLine("username?");
        //kolla om det redan finns
        Console.WriteLine("password?");
        //svar
        Console.WriteLine("repeat password?");
        //svar

        // lägga till användaramnet och lösenordet i accountlistan

    }
}
