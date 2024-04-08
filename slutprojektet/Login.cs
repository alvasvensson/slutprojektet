namespace slutprojektet;
using Raylib_cs;

public class Login : Screen
{
    //Variables
    private AccountManager _accountManager;
    private IRenderable _renderer = new LoginRenderer();
    private string currentInputBox = "username";
    public string username = "";
    public string password = "";

    //Constructor
    public Login(AccountManager manager)
    {
        _accountManager = manager;
    }

    //Collects logininformation from the user by calling the Write.Input method,
    //runs it through the accountmanagers login method,
    //based on the results, returns the correct screen accordingly 
    public override Screen IsHappening()
    {
        ((LoginRenderer)_renderer).Username = username;
        ((LoginRenderer)_renderer).Password = password;
        ((LoginRenderer)_renderer).Draw();
        _renderer.Draw();
        int key = Raylib.GetKeyPressed();
        if (currentInputBox == "username")
        {
            username = Write.Input(username, 200, key);
            if (key == 257)
            {
                currentInputBox = "password";
            }
        }
        else if (currentInputBox == "password")
        {
            password = Write.Input(password, 400, key);
            if (key == 257)
            {
                Account loggedInAccount = _accountManager.LogIn(username, password);
                if (loggedInAccount != null)
                {
                    return new Home(loggedInAccount);
                }
            }
        }
        return this;
    }
}
