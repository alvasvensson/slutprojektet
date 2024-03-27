namespace slutprojektet;
using Raylib_cs;

public class HomeRenderer : IRenderable
{
    //Draws everything in the scene
    public void Draw()
    {
        Raylib.DrawText("welcome", 100, 100, 30, Color.Blue);
    }
}
