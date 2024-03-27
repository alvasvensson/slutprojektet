namespace slutprojektet;
using Raylib_cs;

public class Write
{
    //transforms user keyboard input to a string, and draws it on the screen
    public static string Input(string text, int y, int key)
    {
        if (key != 0)
        {
            if (key == 259)
            {
                try
                {
                    text = text.Substring(0, text.Length - 1);
                }
                catch
                {
                    text = text.Substring(0, text.Length);
                }
            }
            else if (text.Length < 10 && key >= 65 && key <= 90)
            {
                text += (char)key;
            }
            Raylib.DrawText(text, 100, y, 16, Color.White);
        }
        return text;
    }
}
