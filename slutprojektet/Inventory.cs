namespace slutprojektet;
using Raylib_cs;

//This class isn't used in the final version of the game
public class Inventory
{
    public string _name { get; set; }


    public void Draw()
    {
        Raylib.DrawText("hello", 100, 200, 20, Color.Blue);
    }

}
