using System.Security.Cryptography.X509Certificates;

namespace slutprojektet;
using Raylib_cs;

public class Home : Screen
{
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
