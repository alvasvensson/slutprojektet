using System.IO;
using RestSharp;
using System.Text.Json;
using Raylib_cs;
using slutprojektet;

Raylib.InitWindow(600, 800, "Pokemon");

RestClient client = new("https://pokeapi.co/api/v2/");

Inventory inv = new Inventory();

AccountManager AM = new AccountManager();
StartPageRender startPageRender = new();

Screen currentScreen = new Startpage(AM);

Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    currentScreen = currentScreen.IsHappening();

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.Black);

    inv.Draw();
    startPageRender.Draw();


    Raylib.EndDrawing();
}

AM.Load();
AM.CreateAccount();
AM.Save();

Console.ReadLine();


