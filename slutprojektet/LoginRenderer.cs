namespace slutprojektet;
using Raylib_cs;

public class LoginRenderer : IRenderable
{
    public static void Draw()
    {
        Raylib.DrawText("Username?", 100, 100, 16, Color.White);
        Write.Input();

    }

    public void Input()
    {

    }
}
