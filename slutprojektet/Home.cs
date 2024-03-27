namespace slutprojektet;
using Raylib_cs;

public class Home : Screen
{
    //Variables
    private IRenderable _renderer = new HomeRenderer();
    public Home(Account loggedInAccount)
    {

    }
    public override Screen IsHappening()
    {
        ((HomeRenderer)_renderer).Draw();
        return this;
    }

}
