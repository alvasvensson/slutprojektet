namespace slutprojektet;
using Raylib_cs;

public class StartPageRender : IRenderable
{
    //Variables
    Rectangle loginButton = new Rectangle(500, 100, 50, 50);
    Rectangle createAccountButton = new Rectangle(500, 200, 50, 50);

    // Draws everything in the Scene
    public void Draw()
    {
        Raylib.DrawRectangleRec(loginButton, Color.White);
        Raylib.DrawText("login", 500, 100, 30, Color.Black);

        Raylib.DrawRectangleRec(createAccountButton, Color.White);
        Raylib.DrawText("Create Account", 500, 200, 20, Color.Black);

    }
}
