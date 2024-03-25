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


    public override Screen IsHappening()
    {
        _renderer.Draw();
        Rectangle loginButton = new Rectangle(500, 100, 50, 50);
        Rectangle createAccountButton = new Rectangle(500, 200, 50, 50);
        System.Numerics.Vector2 mousePos = Raylib.GetMousePosition();
        bool wantLogIn = Raylib.CheckCollisionPointRec(mousePos, loginButton);
        bool wantCreateAccount = Raylib.CheckCollisionPointRec(mousePos, createAccountButton);

        if (Raylib.IsMouseButtonPressed(MouseButton.Left) && wantLogIn == true)
        {
            // _accountManager.LogIn();
            return new Login(_accountManager);
        }
        if (Raylib.IsMouseButtonPressed(MouseButton.Left) && wantCreateAccount == true)
        {
            return new CreateAccount(_accountManager);
        }

        return this;
    }
}
