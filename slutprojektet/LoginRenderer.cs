namespace slutprojektet;
using Raylib_cs;

public class LoginRenderer : IRenderable
{
    public string Username { get; set; }
    public string Password { get; set; }

    public void Draw()
    {
        Raylib.DrawText("Username?", 100, 100, 16, Color.White);
        Raylib.DrawText(Username, 100, 200, 16, Color.Beige);
        Raylib.DrawText("Password?", 100, 300, 16, Color.White);
        Raylib.DrawText(Password, 100, 400, 16, Color.Beige);

    }

    public void Input()
    {

    }
}
