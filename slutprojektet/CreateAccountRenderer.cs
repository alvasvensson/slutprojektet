namespace slutprojektet;
using Raylib_cs;

public class CreateAccountRenderer : IRenderable
{
    public string Username { get; set; }
    public string PasswordTry1 { get; set; }
    public string PasswordTry2 { get; set; }

     public void Draw()
    {
        Raylib.DrawText("Username?", 100, 100, 16, Color.White);
        Raylib.DrawText(Username, 100, 200, 16, Color.Beige);
        Raylib.DrawText("Password?", 100, 300, 16, Color.White);
        Raylib.DrawText(PasswordTry1, 100, 400, 16, Color.Beige);
        Raylib.DrawText("Repeat Password?", 100, 500, 16, Color.White);
        Raylib.DrawText(PasswordTry2, 100, 600, 16, Color.Beige);

    }

}
