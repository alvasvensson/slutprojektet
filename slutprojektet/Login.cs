﻿namespace slutprojektet;
using Raylib_cs;

public class Login : Screen
{
    private AccountManager _accountManager;
    private IRenderable _renderer = new LoginRenderer();
    string currentInputBox = "username";
    public string username = "";
    public string password = "";
    public Login(AccountManager manager)
    {
        _accountManager = manager;
    }

    public override Screen IsHappening()
    {
        ((LoginRenderer)_renderer).Username = username;
        ((LoginRenderer)_renderer).Password = password;
        ((LoginRenderer)_renderer).Draw();
        _renderer.Draw();
        int key = Raylib.GetKeyPressed();
        if (currentInputBox == "username")
        {
            username = Write.Input(username, 200, key);
            if (key == 257)
            {
                currentInputBox = "password";
            }
        }
        else if (currentInputBox == "password")
        {
            password = Write.Input(password, 400, key);
        }
        if (key == 257)
        {
            bool t =_accountManager.LogIn(username, password);
            if (!t)
            {

            }
        }
        return this;
    }
}
