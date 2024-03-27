using System.Text.Json;
using Raylib_cs;
namespace slutprojektet;

public class AccountManager
{
    //List that holds all exsisting accounts while programme is running
    List<Account> accounts = new List<Account>();

    //Collects all accounts from a database, adds them to the accounts List
    public void Load()
    {
        string hej = File.ReadAllText("accounts.json");
        accounts = JsonSerializer.Deserialize<List<Account>>(hej);
    }

    //Recieves user logininformation, checks if username exists in the accountslist
    //Compares password to the registered password belonging to the username
    //If the logininformation is correct, it returns the selected account
    //else returns null
    public Account LogIn(string username, string password)
    {
        bool userExists = false;
        int chosenAccount = -1;
        // return null;
        for (int a = 0; a < accounts.Count; a++)
        {
            if (username == accounts[a].Username)
            {
                userExists = true;
                chosenAccount = a;
                break;
            }

            else
            {
                userExists = false;
            }
        }

        if (userExists == true)
        {
            if (password == accounts[chosenAccount].Password)
            {
                return accounts[chosenAccount];
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }



    }

    //Writes all accounts in the accounts List to the database
    public void Save()
    {
        string json = JsonSerializer.Serialize<List<Account>>(accounts);
        File.WriteAllText("accounts.json", json);
    }

    //Recieves userinput, compares username to the accounts List
    //If it doesn't exist, compares the two passwordtires,
    //If they are the same, add the account to the accountslist
    public Account CreateAccount(string usernameTry, string passwordTry1, string passwordTry2)
    {
        while (accounts.Where(a => a.Username == usernameTry).Count() > 0)
        {
            return null;
        }

        if (passwordTry1 == passwordTry2)
        {
            Account n = new Account(usernameTry, passwordTry1);
            accounts.Add(n);
            Console.WriteLine(accounts.Count);
            return n;
        }
        return null;
    }
}

