﻿namespace slutprojektet;
using Raylib_cs;

public class Write
{

    public static string Input(string text, int y)
    {
        int key = Raylib.GetKeyPressed();
        if (key != 0)
        {
            if (key != 13)
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
                else if (text.Length < 10)
                {
                    text += (char)key;
                }
                Raylib.DrawText(text, 100, y, 16, Color.White);
            }
        }
        return text;
    }
}
