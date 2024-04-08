using System.IO;
using RestSharp;
using System.Text.Json;
using Raylib_cs;
using slutprojektet;

//opens the raylib window when the programme is started
Raylib.InitWindow(600, 800, "Pokemon");

//Instances
AccountManager AM = new AccountManager();
StartPageRender startPageRender = new();

Screen currentScreen = new Startpage(AM, startPageRender);


Raylib.SetTargetFPS(60);

AM.Load();
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.Black);
    currentScreen = currentScreen.IsHappening();

    Raylib.EndDrawing();
}

AM.Save();

Console.ReadLine();


