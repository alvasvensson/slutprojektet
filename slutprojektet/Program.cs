using System.IO;
using RestSharp;
using System.Text.Json;
using Raylib_cs;
using slutprojektet;

Raylib.InitWindow(600, 800, "Pokemon");

RestClient client = new("https://pokeapi.co/api/v2/");

Inventory inv = new Inventory();

while (!Raylib.WindowShouldClose())
{
    Raylib.SetTargetFPS(60);
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.Black);

    inv.Draw();

    Raylib.EndDrawing();
}


