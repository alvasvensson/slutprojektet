namespace slutprojektet;
using Raylib_cs;

public class Inventory
{
    public string _name { get; set; }


    public void Draw()
    {
        Raylib.DrawText("hello", 100, 200, 20, Color.Blue);
    }

}
