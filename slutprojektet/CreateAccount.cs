namespace slutprojektet;
using Raylib_cs;

public class CreateAccount : Screen
{
    private AccountManager _accountManager;
    private IRenderable _renderer = new CreateAccountRenderer();
    string currentInputBox = "username";
    public string username = "";
    public string passwordTry1 = "";
    public string passwordTry2 = "";

    public CreateAccount(AccountManager manager)
    {
        _accountManager = manager;
    }
    public override Screen IsHappening()
    {
        ((CreateAccountRenderer)_renderer).Username = username;
        ((CreateAccountRenderer)_renderer).PasswordTry1 = passwordTry1;
        ((CreateAccountRenderer)_renderer).PasswordTry2 = passwordTry2;
        ((CreateAccountRenderer)_renderer).Draw();

        int key = Raylib.GetKeyPressed();
        if (currentInputBox == "username")
        {
            username = Write.Input(username, 200, key);
            if (key == 257)
            {
                currentInputBox = "passwordTry1";
            }
        }
        else if (currentInputBox == "passwordTry1")
        {
            passwordTry1 = Write.Input(passwordTry1, 400, key);
            if (key == 257)
            {
                currentInputBox = "passwordTry2";
            }
        }
        else if (currentInputBox == "passwordTry2")
        {
            passwordTry2 = Write.Input(passwordTry2, 400, key);
            if (key == 257)
            {
                Account newAccount = _accountManager.CreateAccount(username, passwordTry1, passwordTry2);
                if (newAccount != null)
                {
                    return new Home(newAccount);
                }
            }
        }

        return this;
    }

}
