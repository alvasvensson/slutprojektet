namespace slutprojektet;

public class AccountManager
{
    List<Account> accounts = new List<Account>();
    //Läsa in JSOn filen och lägga in alla objekt i den till accountslistan

    public bool LogIn()
    {
        bool userExists = false;
        int chosenAccount = -1;
        Console.WriteLine("Username?");
        string inputUN = Console.ReadLine();
        //checka om det användarnamnet finns
        for (int a = 0; a < accounts.Count; a++)
        {
            if (inputUN == accounts[a].Username)
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
            Console.WriteLine("password?");
            // kolla om lösenordet matcher det angivna användarnamnets lösenord
            string inputPW = Console.ReadLine();
            if (inputPW == accounts[chosenAccount].Password)
            {
                Console.WriteLine($"Welcome back {accounts[chosenAccount].Username}!");
                return true;
            }
            else
            {
                return false;
            }


        }
        else
        {
            Console.WriteLine("We couldn't find a user by that name");
            return false;
        }



    }
    public void CreateAccount()
    {
        string usernameTry = "";

        Console.WriteLine("username?");

        //kolla om det redan finns
        usernameTry = Console.ReadLine();
        foreach (Account a in accounts)
        {
            if (usernameTry == a.Username)
            {
                break;
            }
            else
            {
                Console.WriteLine("password?");
                string passwordTry1 = Console.ReadLine();
                Console.WriteLine("repeat password?");
                string passwordTry2 = Console.ReadLine();
                if (passwordTry1 == passwordTry2)
                {
                    //lyckat, lägg till i accountlistan 
                }
                else
                {
                    //fail
                }

            }
        }



        // lägga till användaramnet och lösenordet i accountlistan

    }
}
