namespace slutprojektet;
using Raylib_cs;

public class Startpage : Screen
{
    private AccountManager _accountManager;

    private IRenderable _renderer;
    public Startpage(AccountManager manager, IRenderable renderer)
    {
        _accountManager = manager;
        _renderer = renderer;
    }

    public void Render()
    {
        _renderer.Draw();
    }

    public override Screen IsHappening()
    {
        Rectangle loginButton = new Rectangle(500, 100, 50, 50);
        System.Numerics.Vector2 mousePos = Raylib.GetMousePosition();
        bool wantLogIn = Raylib.CheckCollisionPointRec(mousePos, loginButton);

        if (Raylib.IsMouseButtonPressed(MouseButton.Left) && wantLogIn == true)
        {
            _accountManager.LogIn();
            return new Login(_accountManager);
        }

        return this;
    }
}
