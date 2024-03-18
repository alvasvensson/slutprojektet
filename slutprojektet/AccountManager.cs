using System.Text.Json;
using Raylib_cs;
namespace slutprojektet;

public class AccountManager
{
    List<Account> accounts = new List<Account>();
    public void Load()
    {
        //Läsa in JSOn filen och lägga in alla objekt i den till accountslistan
        string hej = File.ReadAllText("accounts.json");
        accounts = JsonSerializer.Deserialize<List<Account>>(hej);
    }

    public bool LogIn(string username, string password)
    {
        bool userExists = false;
        int chosenAccount = -1;
        return false;
        // Console.WriteLine("Username?");
        // string inputUN = Console.ReadLine();
        //checka om det användarnamnet finns
        // for (int a = 0; a < accounts.Count; a++)
        // {
        //     if (inputUN == accounts[a].Username)
        //     {
        //         userExists = true;
        //         chosenAccount = a;
        //         break;
        //     }

        //     else
        //     {
        //         userExists = false;
        //     }
        // }

        // if (userExists == true)
        // {
        //     Console.WriteLine("password?");
        //     // kolla om lösenordet matcher det angivna användarnamnets lösenord
        //     string inputPW = Console.ReadLine();
        //     if (inputPW == accounts[chosenAccount].Password)
        //     {
        //         Console.WriteLine($"Welcome back {accounts[chosenAccount].Username}!");
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }


        // }
        //     else
        //     {
        //         Console.WriteLine("We couldn't find a user by that name");
        //         return false;
        //     }



    }

    public void Save()
    {
        string json = JsonSerializer.Serialize<List<Account>>(accounts);
        File.WriteAllText("accounts.json", json);
    }

    public void CreateAccount()
    {
        string usernameTry = "";
        string passwordTry1 = "";
        string passwordTry2 = "";
        Console.WriteLine(accounts.Count);

        Console.WriteLine("username?");

        //kolla om det redan finns
        usernameTry = Console.ReadLine();

        while (accounts.Where(a => a.Username == usernameTry).Count() > 0)
        {
            Console.WriteLine("That username is taken, try another one");
            usernameTry = Console.ReadLine();
        }

        Console.WriteLine("password?");
        passwordTry1 = Console.ReadLine();
        Console.WriteLine("repeat password?");
        passwordTry2 = Console.ReadLine();
        while (passwordTry1 != passwordTry2)
        {
            Console.WriteLine("passwords doesnt match, try again");
            Console.WriteLine("password?");
            passwordTry1 = Console.ReadLine();
            Console.WriteLine("repeat password?");
            passwordTry2 = Console.ReadLine();
        }
        Account n = new Account(usernameTry, passwordTry1);
        accounts.Add(n);
        Console.WriteLine(accounts.Count);
        // WHILE användarnmn finns i listan:
        // Läs in nytt

        // Lägg till ny användare

        // foreach (Account a in accounts)
        // {
        //     if (usernameTry == a.Username)
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("password?");
        //         string passwordTry1 = Console.ReadLine();
        //         Console.WriteLine("repeat password?");
        //         string passwordTry2 = Console.ReadLine();
        //         if (passwordTry1 == passwordTry2)
        //         {
        //             //lyckat, lägg till i accountlistan 
        //         }
        //         else
        //         {
        //             //fail
        //         }

        //     }
        // }



        // lägga till användaramnet och lösenordet i accountlistan

    }
}
