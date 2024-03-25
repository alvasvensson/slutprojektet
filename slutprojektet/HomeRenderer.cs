namespace slutprojektet;
using Raylib_cs;

public class HomeRenderer : IRenderable
{
    public void Draw()
    {
        Raylib.DrawText("welcome", 100, 100, 30, Color.Blue);
    }
}
