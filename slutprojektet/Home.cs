namespace slutprojektet;
using Raylib_cs;

public class Home : Screen
{
    //Variables
    private IRenderable _renderer = new HomeRenderer();
    private Account _loggedInAccount;

    //Constructor
    public Home(Account loggedInAccount)
    {
        _loggedInAccount = loggedInAccount;
    }

    //Runs the Draw method and returns this Home Screen
    public override Screen IsHappening()
    {
        ((HomeRenderer)_renderer).Draw(_loggedInAccount.Username);
        return this;
    }

}
