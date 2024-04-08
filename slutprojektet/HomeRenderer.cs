namespace slutprojektet;
using Raylib_cs;

public class HomeRenderer : IRenderable
{
    //Draws everything in the scene
    public void Draw(string username)
    {
        Raylib.DrawText($"welcome {username}", 100, 100, 30, Color.Blue);
    }
}
