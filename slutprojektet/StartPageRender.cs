namespace slutprojektet;
using Raylib_cs;

public class StartPageRender : IRenderable
{

    Rectangle loginButton = new Rectangle(500, 100, 50, 50);
    System.Numerics.Vector2 mousePos = Raylib.GetMousePosition();
    public void Draw()
    {
        Raylib.DrawRectangleRec(loginButton, Color.White);
        Raylib.DrawText("login", 500, 100, 30, Color.Black);


        
    }
}
