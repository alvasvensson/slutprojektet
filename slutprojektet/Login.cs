namespace slutprojektet;

public class Login : Screen
{
    private AccountManager _accountManager;
    public Login(AccountManager manager)
    {
        _accountManager = manager;
    }

    public override Screen IsHappening()
    {
        return this; 
    }
}
